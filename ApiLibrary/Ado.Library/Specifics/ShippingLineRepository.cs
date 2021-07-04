using Models.Dtos;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;

namespace Ado.Library.Specifics
{ 
    public class ShippingLineRepository : AdoRepository<ShippingLine>, IShippingLineRepository
    {
        public ShippingLineRepository(BookStoreEntities context,  string identificator = "IdShippingLine") : base(context, identificator)
        {
        }
    }
}