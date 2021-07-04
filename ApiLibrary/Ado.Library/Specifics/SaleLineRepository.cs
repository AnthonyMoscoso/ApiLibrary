using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;

namespace Ado.Library.Specifics
{
    public class SaleLineRepository : AdoRepository<SaleLine>, ISaleLineRepository
    {
        public SaleLineRepository(BookStoreEntities context, string identificator="IdSaleLine") : base(context,identificator)
        {
        }

        public IEnumerable<SaleLine> GetBySale(string idSale)
        {
            return dbSet.Where(w => w.IdSale.Equals(idSale)).ToList();
        }
    }
}