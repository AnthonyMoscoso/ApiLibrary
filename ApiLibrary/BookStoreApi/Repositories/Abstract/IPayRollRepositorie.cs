using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.PayRolls
{
    interface IPayRollRepositorie : IRepository <PayRoll>
    {
        new dynamic Insert(List<PayRoll> list);
        new dynamic Update(List<PayRoll> list);
        new dynamic Delete(List<string> ids);
        List<PayRollDto> GetByEmployee(string idEmployee);
        List<PayRollDto> GetByEmployee(string idEmployee,int pag,int element);
        List<PayRollDto> GetByEmployee(string idEmployee,int year);
        List<PayRollDto> GetByEmployee(string idEmployee, int year,int pag,int element);
        List<PayRollDto> GetByEmployee(string idEmployee, int year,int mounth,int pag,int element);
        List<PayRollDto> GetByDate(int year);
        List<PayRollDto> GetByDate(int year,int pag,int element);
        List<PayRollDto> GetByDate(int year,int mounth);
        List<PayRollDto> GetByDate(int year,int mounth,int pag,int element);
        List<PayRollDto> GetByDate(DateTime date);
    }
}
