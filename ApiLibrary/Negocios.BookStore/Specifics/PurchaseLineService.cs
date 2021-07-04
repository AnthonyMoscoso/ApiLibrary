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
    public class PurchaseLineService : ServiceMapperBase<PurchaseLineDto, PurchaseLine>, IPurchaseLineService
    {
        readonly new IPurchaseLineRepository _repository;
        public PurchaseLineService(IPurchaseLineRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<PurchaseLineDto> GetByPurchase(string idPruchase)
        {
            IEnumerable<PurchaseLine> result = _repository.GetByPurchase(idPruchase);
            return mapper.Map<IEnumerable<PurchaseLineDto>>(result);
        }
    }
}
