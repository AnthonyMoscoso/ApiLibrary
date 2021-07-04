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
    public class PayRollService : ServiceMapperBase<PayRollDto, PayRoll>, IPayRollService
    {
        readonly new IPayRollRepository _repository;
        public PayRollService(IPayRollRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<PayRollDto> GetByDate(int year)
        {
            IEnumerable<PayRoll> result = _repository.GetByDate(year);
            return mapper.Map<IEnumerable<PayRollDto>>(result);
        }

        public IEnumerable<PayRollDto> GetByDate(int year, int pag, int element)
        {
            IEnumerable<PayRoll> result = _repository.GetByDate(year, pag, element);
            return mapper.Map<IEnumerable<PayRollDto>>(result);
        }

        public IEnumerable<PayRollDto> GetByDate(int year, int mounth)
        {
            IEnumerable<PayRoll> result = _repository.GetByDate(year, mounth); ;
            return mapper.Map<IEnumerable<PayRollDto>>(result);
        }

        public IEnumerable<PayRollDto> GetByDate(int year, int mounth, int pag, int element)
        {
            IEnumerable<PayRoll> result = _repository.GetByDate(year, mounth, pag, element);
            return mapper.Map<IEnumerable<PayRollDto>>(result);
        }

        public IEnumerable<PayRollDto> GetByDate(DateTime date)
        {
            IEnumerable<PayRoll> result = _repository.GetByDate(date);
            return mapper.Map<IEnumerable<PayRollDto>>(result);
        }

        public IEnumerable<PayRollDto> GetByEmployee(string idEmployee)
        {
            IEnumerable<PayRoll> result = _repository.GetByEmployee(idEmployee);
            return mapper.Map<IEnumerable<PayRollDto>>(result);
        }

        public IEnumerable<PayRollDto> GetByEmployee(string idEmployee, int pag, int element)
        {
            IEnumerable<PayRoll> result = _repository.GetByEmployee(idEmployee, pag, element);
            return mapper.Map<IEnumerable<PayRollDto>>(result);
        }

        public IEnumerable<PayRollDto> GetByEmployee(string idEmployee, int year)
        {
            IEnumerable<PayRoll> result = _repository.GetByEmployee(idEmployee, year);
            return mapper.Map<IEnumerable<PayRollDto>>(result);
        }

        public IEnumerable<PayRollDto> GetByEmployee(string idEmployee, int year, int pag, int element)
        {
            IEnumerable<PayRoll> result = _repository.GetByEmployee(idEmployee, year, pag, element);
            return mapper.Map<IEnumerable<PayRollDto>>(result);
        }

        public IEnumerable<PayRollDto> GetByEmployee(string idEmployee, int year, int mounth, int pag, int element)
        {
            IEnumerable<PayRoll> result = _repository.GetByEmployee(idEmployee, year, mounth, pag, element); ;
            return mapper.Map<IEnumerable<PayRollDto>>(result);
        }
    }
}
