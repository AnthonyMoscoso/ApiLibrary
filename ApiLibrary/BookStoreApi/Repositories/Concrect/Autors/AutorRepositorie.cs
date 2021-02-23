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

        public List<Autor> GetAutorLikeName(string text)
        {
             List<Autor> list=  dbSet.Where(w => w.AutorName.Contains(text)).OrderBy(w => w.AutorName).ToList();
             return list;
        }
    }
}