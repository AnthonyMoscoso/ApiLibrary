using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.DBAccess.Ado;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Specifics
{
    public class PayRollService : ServiceMapperBase<PayRollDto, PayRoll>, IPayRollService
    {
        public PayRollService(IPayRollRepository repository) : base(repository)
        {
        }

        public IEnumerable<PayRollDto> GetByDate(int year)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayRollDto> GetByDate(int year, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayRollDto> GetByDate(int year, int mounth)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayRollDto> GetByDate(int year, int mounth, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayRollDto> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayRollDto> GetByEmployee(string idEmployee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayRollDto> GetByEmployee(string idEmployee, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayRollDto> GetByEmployee(string idEmployee, int year)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayRollDto> GetByEmployee(string idEmployee, int year, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PayRollDto> GetByEmployee(string idEmployee, int year, int mounth, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
