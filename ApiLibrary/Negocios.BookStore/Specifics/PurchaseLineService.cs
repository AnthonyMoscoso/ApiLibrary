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
    public class PurchaseLineService : ServiceMapperBase<PurchaseLineDto, PurchaseLine>, IPurchaseLineService
    {
        public PurchaseLineService(IPurchaseLineRepository repository) : base(repository)
        {
        }

        public IEnumerable<PurchaseLineDto> GetByPurchase(string idPruchase)
        {
            throw new NotImplementedException();
        }
    }
}
