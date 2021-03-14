using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Editions;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Editions
{
    public class EditionRepositorie : Repositorie<Edition>, IEditionRepositorie
    {
        public EditionRepositorie(string identificator="IdEdition") : base(identificator)
        {
        }

        public List<Edition> SearchByName(string text)
        {
            return dbSet.Where(w => w.EditionName.Contains(text)).ToList(); 
        }

        public List<Edition> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.EditionName.Contains(text)).Skip((pag - 1) * element).Take(element).ToList();
        }
    }
}