using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.PayRolls
{
    interface IPayRollRepositorie : IRepositorie <PayRoll>
    {
        List<PayRoll> GetByEmployee(string idEmployee);
        List<PayRoll> GetByEmployee(string idEmployee,int pag,int element);
        List<PayRoll> GetByEmployee(string idEmployee,int year);
        List<PayRoll> GetByEmployee(string idEmployee, int year,int pag,int element);
        List<PayRoll> GetByEmployee(string idEmployee, int year,int mounth,int pag,int element);
        List<PayRoll> GetByDate(int year);
        List<PayRoll> GetByDate(int year,int pag,int element);
        List<PayRoll> GetByDate(int year,int mounth);
        List<PayRoll> GetByDate(int year,int mounth,int pag,int element);
        List<PayRoll> GetByDate(DateTime date);
    }
}
