using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;


namespace Ado.Library.Specifics
{
    public class PayRollRepository : AdoRepository<PayRoll>, IPayRollRepository
    {
        public PayRollRepository(BookStoreEntities context,DbSerilogService serilogService,string identificator="IdPayRoll") : base(context,identificator)
        {
        }

        public IEnumerable<PayRoll> GetByDate(int year)
        {
            IEnumerable<PayRoll> result = dbSet.Where(w => w.YearValue == year);
            return result;
        }

        public IEnumerable<PayRoll> GetByDate(int year, int mounth)
        {
            IEnumerable<PayRoll> result = dbSet.Where(w => w.YearValue == year && w.MonthNum == mounth);
            return result;
        }

        public IEnumerable<PayRoll> GetByDate(DateTime date)
        {
            IEnumerable<PayRoll> result = dbSet.Where(w => w.CreateDate.Date == date.Date);
            return result;
        }

        public IEnumerable<PayRoll> GetByDate(int year, int pag, int element)
        {
            IEnumerable<PayRoll> result = dbSet.Where(w => w.YearValue == year)
                   .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return result;
        }

        public IEnumerable<PayRoll> GetByDate(int year, int mounth, int pag, int element)
        {
            IEnumerable<PayRoll> result = dbSet.Where(w => w.YearValue == year && w.MonthNum == mounth)
                   .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return result;
        }

        public IEnumerable<PayRoll> GetByEmployee(string idEmployee)
        {
            IEnumerable<PayRoll> result = dbSet.Where(w => w.IdEmployee.Equals(idEmployee));
            return result;
        }

        public IEnumerable<PayRoll> GetByEmployee(string idEmployee, int year)
        {
            IEnumerable<PayRoll> result = dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year);
            return result;
        }

        public IEnumerable<PayRoll> GetByEmployee(string idEmployee, int year, int mounth)
        {
            IEnumerable<PayRoll> result = dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year && w.MonthNum == mounth);
            return result;
        }

        public IEnumerable<PayRoll> GetByEmployee(string idEmployee, int year, int pag, int element)
        {
            IEnumerable<PayRoll> result = dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year)
                   .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return result;
        }

        public IEnumerable<PayRoll> GetByEmployee(string idEmployee, int year, int mounth, int pag, int element)
        {
            IEnumerable<PayRoll> result = dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year && w.MonthNum == mounth)
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return result;
        }

            public new dynamic Insert(List<PayRoll> list)
        {
            string message = "";
            List<PayRoll> PayRollWithTaxes = new List<PayRoll>();
            List<PayRoll> PayRollWithBonus = new List<PayRoll>();
            ManageTaxes(list, PayRollWithTaxes);
            ManagePaymentBonus(list, PayRollWithBonus);
             base.Insert(list);

            if (PayRollWithTaxes.Count > 0)
            {
                foreach (PayRoll p in PayRollWithTaxes)
                {
                    foreach (Taxes t in p.Taxes)
                    {
                        var query = $"Insert into PayRollTaxes values ('{p.IdPayRoll}','{t.IdTaxes}')";
                        base.ExecuteQuery(query);
                    }
                }
            
            }

            if (PayRollWithBonus.Count > 0)
            {
                foreach (PayRoll p in PayRollWithBonus)
                {
                    foreach (PaymentBonus t in p.PaymentBonus)
                    {
                        var query = $"Insert into PayRollBonus values ('{t.IdPaymentBonus}','{p.IdPayRoll}')";
                        base.ExecuteQuery(query);
                    }
                }
              
            }

            return Save();

           
        }

        public new dynamic Update(IEnumerable<PayRoll> list)
        {
            string message = "";
            foreach (PayRoll payRoll in list)
            {
               PayRoll search = dbSet.Find(payRoll.IdPayRoll);
                if (search != null)
                {
                    IList<Taxes> TaxesInDdb = search.Taxes.ToList();
                    IList<PaymentBonus> BonusInDb = search.PaymentBonus.ToList();
                    if (TaxesInDdb.Count() > 0)
                    {
                        if (payRoll.Taxes.Count > 0)
                        {
                            IList<Taxes> taxesInDbDto = (TaxesInDdb);
                            IList<Taxes> taxesDto = (payRoll.Taxes.ToList());

                            DeletePayRollTaxes(taxesInDbDto, taxesDto, payRoll.IdPayRoll);
                            InsertPayRollTaxes(taxesInDbDto, taxesDto, payRoll.IdPayRoll);

                        }
                        else
                        {
                            IList<Taxes> auxList = TaxesInDdb;
                            foreach (Taxes t in auxList)
                            {
                                var query = $"Delete from PayRollBonus where IdPayRoll='{payRoll.IdPayRoll}' and IdTaxes='{t.IdTaxes}'";
                                base.ExecuteQuery(query);
                                TaxesInDdb.Remove(t);
                            }
                          
                        }
                    }
                    else if (payRoll.Taxes.Count > 0)
                    {
                        foreach (Taxes t in payRoll.Taxes)
                        {
                            var query = $"Insert into PayRollTaxes values ('{payRoll.IdPayRoll}','{t.IdTaxes}');";
                            base.ExecuteQuery(query);
                        }
                    }

                    if (BonusInDb.Count > 0)
                    {
                        if (payRoll.PaymentBonus.Count > 0)
                        {
                            var payMentBonusInDbDto = (BonusInDb);
                            var payMentBonusDto = (payRoll.PaymentBonus);
                            DeletePayRollBonus(payMentBonusInDbDto, payMentBonusDto, payRoll.IdPayRoll);
                            InsertPayRollBonus(payMentBonusInDbDto, payMentBonusDto, payRoll.IdPayRoll);
                        }
                        else
                        {
                            var auxList = BonusInDb;
                            foreach (PaymentBonus t in auxList)
                            {
                                var query = $"Delete from PayRollBonus where IdPayRoll='{payRoll.IdPayRoll}' and IdPaymentBonus='{t.IdPaymentBonus}'";
                                base.ExecuteQuery(query);
                            }
                      
                        }
                    }
                    else if (payRoll.PaymentBonus.Count > 0)
                    {
                        foreach (PaymentBonus t in payRoll.PaymentBonus)
                        {
                            var query = $"Insert into PayRollBonus values ('{t.IdPaymentBonus}','{payRoll.IdPayRoll}');";
                            base.ExecuteQuery(query);
                        }
                    }

                }
                else
                {
                    message += $"\n PayRoll with id {payRoll.IdPayRoll} not was found";
                }
            }
            return Save();
           
        }

        public new dynamic Delete(IEnumerable<string> ids)
        {
            string message = "";
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search != null)
                {
                    if (search.Taxes.Count > 0)
                    {
                        foreach (Taxes taxes in search.Taxes)
                        {
                            var query = $"Delete from PayRollTaxes where IdPayRoll='{id}'";
                            base.ExecuteQuery(query);

                        }
                        
                    }
                    if (search.PaymentBonus.Count > 0)
                    {
                        foreach (PaymentBonus bonus in search.PaymentBonus)
                        {
                            var query = $"Delete from PayRollBonus where IdPayRoll='{id}'";
                            base.ExecuteQuery(query);
                        }
                       
                    }

                    try
                    {
                        dbSet.Remove(search);
                        
                        message += $"\n{name} with {Identificator} = {id} was delete";
                    }
                    catch (SqlException e)
                    {
                        message += $"\n{e.Message}";
                    }

                }
                else
                {
                    message += $"\n{name} with {Identificator} {id} not was found";
                }
            }
            return Save();
        }

       private dynamic DeletePayRollTaxes(IList<Taxes> taxesInDbDto, IList<Taxes> taxesDto, string idPayRoll)
        {
            string message = string.Empty;
            foreach (Taxes t in taxesInDbDto)
            {
                if (!taxesDto.Contains(t))
                {
                    var query = $"Delete from PayRollTaxes where IdPayRoll='{idPayRoll}' and IdTaxes='{t.IdTaxes}'";
                    base.ExecuteQuery(query);
                    taxesInDbDto.Remove(t);
                }
            }
            return Save();
         
        }
        private dynamic InsertPayRollTaxes(IList<Taxes> taxesInDbDto, IList<Taxes> taxesDto, string idPayRoll)
        {
            string message = string.Empty;
            foreach (Taxes t in taxesDto)
            {
                if (!taxesInDbDto.Contains(t))
                {
                    var query = $"Insert into PayRollTaxes values ('{idPayRoll}','{t.IdTaxes}');";
                    base.ExecuteQuery(query);
                }

            }
            return Save();
          
        }

       private dynamic DeletePayRollBonus(IList<PaymentBonus> paymentBonusDbDtos, IEnumerable<PaymentBonus> paymentBonusDto, string idPayRoll)
        {
            string message =string.Empty;
            foreach (PaymentBonus t in paymentBonusDbDtos)
            {
                if (!paymentBonusDto.Contains(t))
                {
                    var query = $"Delete from PayRollBonus where IdPayRoll='{idPayRoll}' and IdPaymentBonus='{t.IdPaymentBonus}'";
                    base.ExecuteQuery(query);
                    paymentBonusDbDtos.Remove(t);
                }
            }
            return Save();
            
        }

        private dynamic InsertPayRollBonus(IEnumerable<PaymentBonus> paymentBonusDbDtos, IEnumerable<PaymentBonus> paymentBonusDto, string idPayRoll)
        {
            string message = string.Empty;

            foreach (PaymentBonus dto in paymentBonusDto)
            {
                if (!paymentBonusDbDtos.Contains(dto))
                {
                    var query = $"Insert into PayRollBonus values ('{dto.IdPaymentBonus}','{idPayRoll}');";
                    base.ExecuteQuery(query);
                }
            }
            return Save();
           
        }

        private void ManageTaxes(IEnumerable<PayRoll> list, IList<PayRoll> PayRollWithTaxes)
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
                    IEnumerable<Taxes> taxes = payRoll.Taxes;
                    foreach (Taxes t in taxes)
                    {
                        var search = _Context.Set<Taxes>().Find(t.IdTaxes);
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
        private void ManagePaymentBonus(IEnumerable<PayRoll> list, List<PayRoll> PayRollWithBonus)
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
                    IEnumerable<PaymentBonus> paymentBonus = payRoll.PaymentBonus;
                    foreach (PaymentBonus t in paymentBonus)
                    {
                        var search = _Context.Set<PaymentBonus>().Find(t.IdPaymentBonus);
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