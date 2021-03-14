using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.PayRolls;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.PayRolls
{
    public class PayRollRepositorie : Repositorie<PayRoll>, IPayRollRepositorie
    {
        public PayRollRepositorie(string identificator="IdPayRoll") : base(identificator)
        {
        }

        public List<PayRoll> GetByDate(int year)
        {
            return dbSet.Where(w=>w.YearValue==year).ToList();
        }

        public List<PayRoll> GetByDate(int year, int mounth)
        {
            return dbSet.Where(w => w.YearValue == year && w.MonthNum==mounth).ToList();
        }

        public List<PayRoll> GetByDate(DateTime date)
        {
            return dbSet.Where(w=>w.CreateDate.Date==date.Date).ToList();
        }

        public List<PayRoll> GetByDate(int year, int pag, int element)
        {
            return dbSet.Where(w => w.YearValue == year)
                   .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }

        public List<PayRoll> GetByDate(int year, int mounth, int pag, int element)
        {
            return dbSet.Where(w => w.YearValue == year && w.MonthNum == mounth)
                   .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }

        public List<PayRoll> GetByEmployee(string idEmployee)
        {
            return dbSet.Where(w=>w.IdEmployee.Equals(idEmployee)).ToList();
        }

        public List<PayRoll> GetByEmployee(string idEmployee, int year)
        {
            return dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue==year).ToList();
        }

        public List<PayRoll> GetByEmployee(string idEmployee, int year, int mounth)
        {
            return dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year && w.MonthNum==mounth).ToList();
        }

        public List<PayRoll> GetByEmployee(string idEmployee, int year, int pag, int element)
        {
            return dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year)
                   .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }

        public List<PayRoll> GetByEmployee(string idEmployee, int year, int mounth, int pag, int element)
        {
            return dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year && w.MonthNum == mounth)
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
    }
}