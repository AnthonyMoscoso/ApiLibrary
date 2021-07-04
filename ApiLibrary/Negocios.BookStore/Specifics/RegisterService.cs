using Models.Ado.Library;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.DBAccess.Ado;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ado.Library;

namespace Business.BookStoreServices.Specifics
{
    public class RegisterService : ServiceMapperBase<RegisterDto, Register>, IRegisterService
    {
        readonly  new IRegisterRepository _repository;
        public RegisterService(IRegisterRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<RegisterDto> GetByDate(DateTime date)
        {
            return mapper.Map<IEnumerable<RegisterDto>>(_repository.GetByDate(date));
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
