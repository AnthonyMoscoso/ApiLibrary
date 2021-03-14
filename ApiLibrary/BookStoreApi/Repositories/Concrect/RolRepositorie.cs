using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Rols;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Rols
{
    public class RolRepositorie : Repositorie<Rol>, IRolRepositorie
    {
        public RolRepositorie(string identificator="IdRol") : base(identificator)
        {
        }

        public List<Rol> SearchByName(string text)
        {
            return dbSet.Where(w => w.RolName.Contains(text)).ToList();
        }

        public List<Rol> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.RolName.Contains(text)).Skip((pag - 1) * element).Take(element).ToList();
        }
    }
}