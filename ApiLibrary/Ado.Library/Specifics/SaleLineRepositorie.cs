using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Sales
{
    public class SaleLineRepositorie : Repository<SaleLine,SaleLineDto>, ISaleLineRepositorie
    {
        public SaleLineRepositorie(string identificator="IdSaleLine") : base(identificator)
        {
        }

        public List<SaleLine> GetBySale(string idSale)
        {
            return dbSet.Where(w => w.IdSale.Equals(idSale)).ToList();
        }
    }
}