using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Editorials;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Editorials
{
    public class EditorialRepositorie : Repository<Editorial>, IEditorialRepositorie
    {
        public EditorialRepositorie(string identificator="IdEditorial") : base(identificator)
        {
        }

        public List<Editorial> SearchByName(string text)
        {
            return dbSet.Where(w=>w.EditorialName.Contains(text)).ToList();
        }

        public List<Editorial> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.EditorialName.Contains(text))
                .OrderBy(W=> W.CreateDate)
                .Skip((pag-1)*element).Take(element).ToList();
        }
    }
}