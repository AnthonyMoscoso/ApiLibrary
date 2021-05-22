using Models.Dtos;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Shippings
{
    public class ShippingLineRepositorie : Repository<ShippingLine,ShippingLineDto>, IShippingLineRepositorie
    {
        public ShippingLineRepositorie(string identificator="IdShippingLine") : base(identificator)
        {
        }
    }
}