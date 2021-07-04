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
    public class ReceptionService : ServiceMapperBase<ReceptionDto, Reception>, IReceptionService
    {
        readonly new IReceptionRepository _repository;
        public ReceptionService(IReceptionRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<ReceptionDto> GetByDate(DateTime date)
        {
            IEnumerable<Reception> result = _repository.GetByDate(date);
            return mapper.Map<IEnumerable<ReceptionDto>>(result);
        }

        public IEnumerable<ReceptionDto> GetByDate(DateTime date, int pag, int element)
        {
            IEnumerable<Reception> result = _repository.GetByDate(date);
            return mapper.Map<IEnumerable<ReceptionDto>>(result);
        }

        public IEnumerable<ReceptionDto> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            IEnumerable<Reception> result = _repository.GetByDate(dateStart,dateEnd);
            return mapper.Map<IEnumerable<ReceptionDto>>(result);
        }

        public IEnumerable<ReceptionDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            IEnumerable<Reception> result = _repository.GetByDate(dateStart,dateEnd,pag,element);
            return mapper.Map<IEnumerable<ReceptionDto>>(result);
        }

        public IEnumerable<ReceptionDto> GetByOrder(string idOrder)
        {
            IEnumerable<Reception> result = _repository.GetByOrder(idOrder);
            return mapper.Map<IEnumerable<ReceptionDto>>(result);
        }

        public IEnumerable<ReceptionDto> GetByPurchase(string idPurchase)
        {
            IEnumerable<Reception> result = _repository.GetByPurchase(idPurchase);
            return mapper.Map<IEnumerable<ReceptionDto>>(result);
        }

        public IEnumerable<ReceptionDto> GetByStore(string idStore)
        {
            IEnumerable<Reception> result = _repository.GetByStore(idStore);
            return mapper.Map<IEnumerable<ReceptionDto>>(result);
        }

        public IEnumerable<ReceptionDto> GetByStore(string idStore, int pag, int element)
        {
            IEnumerable<Reception> result = _repository.GetByStore(idStore,pag,element);
            return mapper.Map<IEnumerable<ReceptionDto>>(result);
        }

        public IEnumerable<ReceptionDto> GetByStore(string idStore, DateTime date)
        {
            IEnumerable<Reception> result = _repository.GetByStore(idStore,date);
            return mapper.Map<IEnumerable<ReceptionDto>>(result);
        }

        public IEnumerable<ReceptionDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            IEnumerable<Reception> result = _repository.GetByStore(idStore,date,pag,element);
            return mapper.Map<IEnumerable<ReceptionDto>>(result);
        }
    }
}
