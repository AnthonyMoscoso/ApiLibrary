using Ado.Library;
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

namespace Business.BookStoreServices.Specifics
{
    public class StoreService : ServiceMapperBase<StoreDto, Store>, IStoreService
    {
        public StoreService(IStoreRepository repository) : base(repository)
        {
        }

        public IEnumerable<StoreDto> GetByCountry(string country)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreDto> GetByCountry(string country, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public StoreDto GetByEmployee(string idEmployee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreDto> GetByPoblation(string poblation)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreDto> GetByPoblation(string poblation, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreDto> GetByPostalCode(string postalCode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoreDto> GetByPostalCode(string postalCode, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
