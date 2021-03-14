using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Genders;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Genders
{
    public class GenderRepositorie : Repositorie<Gender>, IGenderRepositorie
    {
        public GenderRepositorie(string identificator="IdGender") : base(identificator)
        {
        }

        public List<Gender> SearchByName(string text)
        {
            return dbSet.Where(w => w.GenderName.Contains(text)).ToList();
        }

        public List<Gender> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.GenderName.Contains(text))
                .OrderBy(w=> w.GenderName)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
    }
}