using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IPayRollRepository : IRepository <PayRoll>
    {
        new dynamic Insert(IEnumerable<PayRoll> list);
        new dynamic Update(IEnumerable<PayRoll> list);
        new dynamic Delete(IEnumerable<string> ids);
        IEnumerable<PayRoll> GetByEmployee(string idEmployee);
        IEnumerable<PayRoll> GetByEmployee(string idEmployee,int pag,int element);
        IEnumerable<PayRoll> GetByEmployee(string idEmployee,int year);
        IEnumerable<PayRoll> GetByEmployee(string idEmployee, int year,int pag,int element);
        IEnumerable<PayRoll> GetByEmployee(string idEmployee, int year,int mounth,int pag,int element);
        IEnumerable<PayRoll> GetByDate(int year);
        IEnumerable<PayRoll> GetByDate(int year,int pag,int element);
        IEnumerable<PayRoll> GetByDate(int year,int mounth);
        IEnumerable<PayRoll> GetByDate(int year,int mounth,int pag,int element);
        IEnumerable<PayRoll> GetByDate(DateTime date);
    }
}
