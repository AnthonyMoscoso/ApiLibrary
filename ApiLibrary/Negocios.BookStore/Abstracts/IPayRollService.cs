using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IPayRollService : IServices<PayRollDto>
    {
        IEnumerable<PayRollDto> GetByEmployee(string idEmployee);
        IEnumerable<PayRollDto> GetByEmployee(string idEmployee, int pag, int element);
        IEnumerable<PayRollDto> GetByEmployee(string idEmployee, int year);
        IEnumerable<PayRollDto> GetByEmployee(string idEmployee, int year, int pag, int element);
        IEnumerable<PayRollDto> GetByEmployee(string idEmployee, int year, int mounth, int pag, int element);
        IEnumerable<PayRollDto> GetByDate(int year);
        IEnumerable<PayRollDto> GetByDate(int year, int pag, int element);
        IEnumerable<PayRollDto> GetByDate(int year, int mounth);
        IEnumerable<PayRollDto> GetByDate(int year, int mounth, int pag, int element);
        IEnumerable<PayRollDto> GetByDate(DateTime date);
    }
}
