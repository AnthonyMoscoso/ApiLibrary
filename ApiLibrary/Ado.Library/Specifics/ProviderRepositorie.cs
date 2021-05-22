using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Provide
{
    public class ProviderRepositorie : Repository<Providers,ProviderDto>, IProviderRepository
    {
        public ProviderRepositorie(string identificator="IdProvider") : base(identificator)
        {
        }

        public List<Providers> SearchByName(string text)
        {
            return dbSet.Where(w => w.ProviderName.Contains(text)).ToList();
        }

        public List<Providers> SearchByName(string text,int pag, int element)
        {
            return dbSet.Where(w => w.ProviderName.Contains(text))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1)*element).Take(element).ToList();
        }
    }
}