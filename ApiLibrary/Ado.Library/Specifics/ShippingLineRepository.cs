using Models.Dtos;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{ 
    public class ShippingLineRepository : Repository<ShippingLine>, IShippingLineRepository
    {
        public ShippingLineRepository(BookStoreEntities context,string identificator="IdShippingLine") : base(context,identificator)
        {
        }
    }
}