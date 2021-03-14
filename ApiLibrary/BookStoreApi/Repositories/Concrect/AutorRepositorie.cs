using BookStoreApi.Models;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApiRest.Repositories.Concrect
{
    public class AutorRepositorie : Repositorie<Autor>, IAutorRepositorie
    {
        public AutorRepositorie(string identificator="IdAutor") : base(identificator)
        {
        }



        public bool ExistName(string name)
        {
            var result =dbSet.Where(W => W.AutorName.Equals(name)).SingleOrDefault();
            if (result!=null)
            {
               return true;
            }
            return false;
        }

        public Autor GetByName(string name)
        {
            var result = dbSet.Where(w=>w.AutorName.Equals(name)).SingleOrDefault();
            return result;
        }

        public List<Autor> SearchByName(string text)
        {
            return dbSet.Where(w=>w.AutorName.Contains(text)).ToList();
        }

        public List<Autor> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.AutorName.Contains(text)).OrderBy(w=> w.AutorName).Skip((pag-1)*element).Take(element).ToList();
        }
    }
}