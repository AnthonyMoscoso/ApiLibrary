using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;


namespace Ado.Library.Specifics
{
    public class ProviderRepository : AdoRepository<Providers>, IProviderRepository
    {
        public ProviderRepository(BookStoreEntities context,  string identificator = "IdProvider") : base(context, identificator)
        {
        }

        public IEnumerable<Providers> SearchByName(string text)
        {
            return dbSet.Where(w => w.ProviderName.Contains(text));
        }

        public IEnumerable<Providers> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.ProviderName.Contains(text))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
        }
    }
}