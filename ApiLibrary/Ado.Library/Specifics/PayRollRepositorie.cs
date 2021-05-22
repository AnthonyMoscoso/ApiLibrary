using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.PayRolls
{
    public class PayRollRepositorie : Repository<PayRoll,PayRollDto>, IPayRollRepositorie
    {
        public PayRollRepositorie(string identificator="IdPayRoll") : base(identificator)
        {
        }

        public List<PayRollDto> GetByDate(int year)
        {
            var result = dbSet.Where(w=>w.YearValue==year).ToList();
            return mapper.Map<List<PayRollDto>>(result);
        }

        public List<PayRollDto> GetByDate(int year, int mounth)
        {
            var result = dbSet.Where(w => w.YearValue == year && w.MonthNum==mounth).ToList();
            return mapper.Map<List<PayRollDto>>(result);
        }

        public List<PayRollDto> GetByDate(DateTime date)
        {
            var result = dbSet.Where(w=>w.CreateDate.Date==date.Date).ToList();
            return mapper.Map<List<PayRollDto>>(result);
        }

        public List<PayRollDto> GetByDate(int year, int pag, int element)
        {
            var result = dbSet.Where(w => w.YearValue == year)
                   .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<PayRollDto>>(result);
        }

        public List<PayRollDto> GetByDate(int year, int mounth, int pag, int element)
        {
            var result = dbSet.Where(w => w.YearValue == year && w.MonthNum == mounth)
                   .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<PayRollDto>>(result);
        }

        public List<PayRollDto> GetByEmployee(string idEmployee)
        {
            var result = dbSet.Where(w=>w.IdEmployee.Equals(idEmployee)).ToList();
            return mapper.Map<List<PayRollDto>>(result);
        }

        public List<PayRollDto> GetByEmployee(string idEmployee, int year)
        {
            var result = dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue==year).ToList();
            return mapper.Map<List<PayRollDto>>(result);
        }

        public List<PayRollDto> GetByEmployee(string idEmployee, int year, int mounth)
        {
            var result = dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year && w.MonthNum==mounth).ToList();
            return mapper.Map<List<PayRollDto>>(result);
        }

        public List<PayRollDto> GetByEmployee(string idEmployee, int year, int pag, int element)
        {
            var result = dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year)
                   .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<PayRollDto>>(result);
        }

        public List<PayRollDto> GetByEmployee(string idEmployee, int year, int mounth, int pag, int element)
        {
            var result = dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year && w.MonthNum == mounth)
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<PayRollDto>>(result);
        }

        public new  dynamic Insert(List<PayRoll> list)
        {
            string message = "";
            List<PayRoll> PayRollWithTaxes = new List<PayRoll>();
            List<PayRoll> PayRollWithBonus= new List<PayRoll>();
            ManageTaxes(list, PayRollWithTaxes);
            ManagePaymentBonus(list, PayRollWithBonus);
            message += base.Insert(list);

            if (PayRollWithTaxes.Count > 0)
            {
                foreach (PayRoll p in PayRollWithTaxes)
                {
                    foreach (Taxes t in p.Taxes)
                    {
                        var query = $"Insert into PayRollTaxes values ('{p.IdPayRoll}','{t.IdTaxes}')";
                        Context.Database.ExecuteSqlCommand(query);
                    }
                }
                message += Save();
            }

            if (PayRollWithBonus.Count > 0)
            {
                foreach (PayRoll p in PayRollWithBonus)
                {
                    foreach (PaymentBonus t in p.PaymentBonus)
                    {
                        var query = $"Insert into PayRollBonus values ('{t.IdPaymentBonus}','{p.IdPayRoll}')";
                        Context.Database.ExecuteSqlCommand(query);
                    }
                }
                message += Save();
            }



            return message;
        }

        public new dynamic Update(List<PayRoll> list)
        {
            string message = "";
            foreach (PayRoll payRoll in list)
            {
                var search = dbSet.Find(payRoll.IdPayRoll);
                if (search!=null)
                {
                    var TaxesInDdb = search.Taxes.ToList();
                    var BonusInDb = search.PaymentBonus.ToList();
                    if (TaxesInDdb.Count>0) 
                    {
                        if (payRoll.Taxes.Count>0)
                        {
                            var taxesInDbDto = mapper.Map<List<TaxesDto>>(TaxesInDdb);
                            var taxesDto = mapper.Map<List<TaxesDto>>(payRoll.Taxes);

                            message += $"\n{DeletePayRollTaxes(taxesInDbDto,taxesDto,payRoll.IdPayRoll)}";
                            message += $"\n{InsertPayRollTaxes(taxesInDbDto,taxesDto,payRoll.IdPayRoll)}";
                           
                        }
                        else
                        {
                            var auxList = TaxesInDdb;
                            foreach (Taxes t in auxList)
                            {
                                var query = $"Delete from PayRollBonus where IdPayRoll='{payRoll.IdPayRoll}' and IdTaxes='{t.IdTaxes}'";
                                Context.Database.ExecuteSqlCommand(query);
                                TaxesInDdb.Remove(t);
                            }
                            message += $"\n{Save()}";
                        }
                    }
                    else if (payRoll.Taxes.Count>0)
                    {
                        foreach (Taxes t in payRoll.Taxes )
                        {
                            var query = $"Insert into PayRollTaxes values ('{payRoll.IdPayRoll}','{t.IdTaxes}');";
                            Context.Database.ExecuteSqlCommand(query);
                        }
                    }

                    if (BonusInDb.Count>0)
                    {
                        if (payRoll.PaymentBonus.Count>0)
                        {
                            var payMentBonusInDbDto = mapper.Map<List<PaymentBonusDto>>(BonusInDb);
                            var payMentBonusDto = mapper.Map<List<PaymentBonusDto>>(payRoll.PaymentBonus);
                            message += $"\n{DeletePayRollBonus(payMentBonusInDbDto, payMentBonusDto, payRoll.IdPayRoll)}";
                            message += $"\n{InsertPayRollBonus(payMentBonusInDbDto, payMentBonusDto, payRoll.IdPayRoll)}";
                        }
                        else
                        {
                            var auxList = BonusInDb;
                            foreach (PaymentBonus t in auxList)
                            {
                                var query = $"Delete from PayRollBonus where IdPayRoll='{payRoll.IdPayRoll}' and IdPaymentBonus='{t.IdPaymentBonus}'";
                                Context.Database.ExecuteSqlCommand(query);
                            }
                            message += $"\n{Save()}";
                        }
                    }
                    else if (payRoll.PaymentBonus.Count>0)
                    {
                        foreach (PaymentBonus t in payRoll.PaymentBonus)
                        {
                            var query = $"Insert into PayRollBonus values ('{t.IdPaymentBonus}','{payRoll.IdPayRoll}');";
                            Context.Database.ExecuteSqlCommand(query);
                        }
                    }

                }
                else
                {
                    message += $"\n PayRoll with id {payRoll.IdPayRoll} not was found";
                }
            }
            return message;
        }

        public new dynamic Delete(List<string> ids)
        {
            string message = "";
            foreach (string id in ids)
            {
                var search= dbSet.Find(id);
                if (search!=null)
                {
                    if (search.Taxes.Count>0)
                    {
                        foreach (Taxes taxes in search.Taxes)
                        {
                            var query = $"Delete from PayRollTaxes where IdPayRoll='{id}'";
                            Context.Database.ExecuteSqlCommand(query);

                        }
                        message += $"\n{Save()}";
                    }
                    if (search.PaymentBonus.Count>0)
                    {
                        foreach (PaymentBonus bonus in search.PaymentBonus)
                        {
                            var query = $"Delete from PayRollBonus where IdPayRoll='{id}'";
                            Context.Database.ExecuteSqlCommand(query);
                        }
                        message += $"\n{Save()}";
                    }

                    try
                    {
                        dbSet.Remove(search);
                        message += $"\n{Save()}";
                        message += $"\n{name} with {Identificator} = {id} was delete";
                    }
                    catch(SqlException e)
                    {
                        message += $"\n{e.Message}";
                    }
                 
                }
                else
                {
                    message += $"\n{name} with {Identificator} {id} not was found";
                }
            }
            return message;
        }

        private string DeletePayRollTaxes(List<TaxesDto> taxesInDbDto, List<TaxesDto> taxesDto,string idPayRoll)
        {
            string message="";
            foreach (TaxesDto t in taxesInDbDto)
            {
                if (!taxesDto.Contains(t))
                {
                    var query = $"Delete from PayRollTaxes where IdPayRoll='{idPayRoll}' and IdTaxes='{t.IdTaxes}'";
                    Context.Database.ExecuteSqlCommand(query);
                    taxesInDbDto.Remove(t);
                }
            }
            return  message += $"\n{Save()}";
        }
        private string InsertPayRollTaxes(List<TaxesDto> taxesInDbDto, List<TaxesDto> taxesDto, string idPayRoll)
        {
            string message = "";
            foreach (TaxesDto t in taxesDto)
            {
                if (!taxesInDbDto.Contains(t))
                {
                    var query = $"Insert into PayRollTaxes values ('{idPayRoll}','{t.IdTaxes}');";
                    Context.Database.ExecuteSqlCommand(query);
                }

            }
            return message += $"\n{Save()}";
        }

        private string DeletePayRollBonus(List<PaymentBonusDto> paymentBonusDbDtos,List<PaymentBonusDto> paymentBonusDto,string idPayRoll)
        {
            string message = "";
            foreach (PaymentBonusDto t in paymentBonusDbDtos)
            {
                if (!paymentBonusDto.Contains(t))
                {
                    var query = $"Delete from PayRollBonus where IdPayRoll='{idPayRoll}' and IdPaymentBonus='{t.IdPaymentBonus}'";
                    Context.Database.ExecuteSqlCommand(query);
                    paymentBonusDbDtos.Remove(t);
                }
            }
            return message += $"\n{Save()}";
        }

        private string InsertPayRollBonus(List<PaymentBonusDto> paymentBonusDbDtos, List<PaymentBonusDto> paymentBonusDto, string idPayRoll)
        {
            string message = "";
          
            foreach (PaymentBonusDto dto in paymentBonusDto)
            {
                if (!paymentBonusDbDtos.Contains(dto))
                {
                    var query = $"Insert into PayRollBonus values ('{dto.IdPaymentBonus}','{idPayRoll}');";
                    Context.Database.ExecuteSqlCommand(query);
                }
            }
            return message += $"\n{Save()}";
        }

        private void ManageTaxes(List<PayRoll> list,List<PayRoll> PayRollWithTaxes)
        {
          

            foreach (PayRoll payRoll in list)
            {

                if (payRoll.Taxes.Count > 0)
                {
                    PayRoll auxPayRoll = new PayRoll()
                    {
                        IdPayRoll = payRoll.IdPayRoll,
                        Taxes = new List<Taxes>()
                    };
                    List<Taxes> taxes = payRoll.Taxes.ToList();
                    foreach (Taxes t in taxes)
                    {
                        var search = Context.Taxes.Find(t.IdTaxes);
                        if (search != null)
                        {
                            payRoll.Taxes.Remove(t);
                            auxPayRoll.Taxes.Add(t);
                        }
                    }
                    if (auxPayRoll.Taxes.Count > 0)
                    {
                        PayRollWithTaxes.Add(auxPayRoll);
                    }
                }

            }
        }
        private void ManagePaymentBonus(List<PayRoll> list, List<PayRoll> PayRollWithBonus)
        {



            foreach (PayRoll payRoll in list)
            {

                if (payRoll.PaymentBonus.Count > 0)
                {
                    PayRoll auxPayRoll = new PayRoll()
                    {
                        IdPayRoll = payRoll.IdPayRoll,
                        PaymentBonus = new List<PaymentBonus>()
                    };
                    List<PaymentBonus> paymentBonus = payRoll.PaymentBonus.ToList();
                    foreach (PaymentBonus t in paymentBonus)
                    {
                        var search = Context.PaymentBonus.Find(t.IdPaymentBonus);
                        if (search != null)
                        {
                            payRoll.PaymentBonus.Remove(t);
                            auxPayRoll.PaymentBonus.Add(t);
                        }
                    }
                    if (auxPayRoll.PaymentBonus.Count > 0)
                    {
                        PayRollWithBonus.Add(auxPayRoll);
                    }
                }

            }

       
        }
    }

    
}