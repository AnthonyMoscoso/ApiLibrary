using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{
    public class SaleLineRepository : Repository<SaleLine>, ISaleLineRepository
    {
        public SaleLineRepository(BookStoreEntities context,string identificator="IdSaleLine") : base(context,identificator)
        {
        }

        public IEnumerable<SaleLine> GetBySale(string idSale)
        {
            return dbSet.Where(w => w.IdSale.Equals(idSale)).ToList();
        }
    }
}