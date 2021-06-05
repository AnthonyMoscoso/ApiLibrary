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
    public class RegisterService : ServiceMapperBase<RegisterDto, Register>, IRegisterService
    {
        public RegisterService(IRepository<Register> repository) : base(repository)
        {
        }

        public IEnumerable<RegisterDto> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByDate(DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByStore(string idStore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByStore(string idStore, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByStore(string idStore, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByStore(string idStore, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByWareHouse(string idWareHouse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByWareHouse(string idWareHouse, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
