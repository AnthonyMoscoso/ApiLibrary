using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Permits;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Permits
{
    public class PermitRepositorie : Repositorie<Permit>, IPermitRepositorie
    {
        public PermitRepositorie(string identificator="IdPermit") : base(identificator)
        {
        }

        public List<Permit> SearchByName(string text)
        {
            return dbSet.Where(w=>w.PermitName.Contains(text)).ToList();
        }

        public List<Permit> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.PermitName.Contains(text)).Skip((pag - 1) * element).Take(element).ToList();
        }
    }
}