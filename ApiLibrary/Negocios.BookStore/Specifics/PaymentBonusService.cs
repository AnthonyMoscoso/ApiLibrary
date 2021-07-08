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
using Core.Logger.Abstracts;

namespace Business.BookStoreServices.Specifics
{
    public class PaymentBonusService : ServiceMapperBase<PaymentBonusDto, PaymentBonus>, IPaymentBonusService
    {
        readonly new IPaymentBonusRepository _repository;
        public PaymentBonusService(IPaymentBonusRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<PaymentBonus> SearchByName(string text)
        {
            IEnumerable<PaymentBonus> result = _repository.SearchByName(text);
            return mapper.Map<IEnumerable<PaymentBonus>>(result);
        }

        public IEnumerable<PaymentBonus> SearchByName(string text, int pag, int element)
        {
            IEnumerable<PaymentBonus> result = _repository.SearchByName(text,pag,element);
            return mapper.Map<IEnumerable<PaymentBonus>>(result);
        }
    }
}
