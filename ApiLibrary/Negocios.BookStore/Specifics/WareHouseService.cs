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
    public class WareHouseService : ServiceMapperBase<WareHouseDto, WareHouse>, IWareHouseService
    {
        new readonly IWareHouseRepository _repository;
        public WareHouseService(IWareHouseRepository repository) : base(repository)
        {
        }

        public IEnumerable<WareHouseDto> GetByCountry(string country)
        {
            IEnumerable<WareHouse> search = _repository.Get(w=> w.Direction.Country.Equals(country));
            return mapper.Map<IEnumerable<WareHouseDto>>(search);
        }

        public IEnumerable<WareHouseDto> GetByCountry(string country, int pag, int element)
        {
            IEnumerable<WareHouse> search = _repository.GetByCountry(country,pag,element);
            return mapper.Map<IEnumerable<WareHouseDto>>(search);
        }

        public WareHouseDto GetByEmployee(string idEmployee)
        {
            WareHouse search = _repository.Get(w => w.Employee.Any(e => e.IdPerson.Equals(idEmployee))).SingleOrDefault();
            return mapper.Map<WareHouseDto>(search);
        }

        public IEnumerable<WareHouseDto> GetByPoblation(string poblation)
        {
            IEnumerable<WareHouse> search = _repository.Get(w=> w.Direction.Poblation.Equals(poblation));
            return mapper.Map<IEnumerable<WareHouseDto>>(search);
        }

        public IEnumerable<WareHouseDto> GetByPoblation(string poblation, int pag, int element)
        {
            IEnumerable<WareHouse> search = _repository.Get(w => w.Direction.Poblation.Equals(poblation)).Skip((pag-1)*element).Take(element);
            return mapper.Map<IEnumerable<WareHouseDto>>(search);
        }

        public IEnumerable<WareHouseDto> GetByPostalCode(string postalCode)
        {
            IEnumerable<WareHouse> search = _repository.Get(w => w.Direction.PostalCode.Equals(postalCode));
            return mapper.Map<IEnumerable<WareHouseDto>>(search);
        }

        public IEnumerable<WareHouseDto> GetByPostalCode(string postalCode, int pag, int element)
        {
            IEnumerable<WareHouse> search = _repository.Get(w => w.Direction.PostalCode.Equals(postalCode)).Skip((pag - 1) * element).Take(element);
            return mapper.Map<IEnumerable<WareHouseDto>>(search);
        }
    }
}
