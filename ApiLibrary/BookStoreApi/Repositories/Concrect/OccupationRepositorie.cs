using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Occupations;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Occupations
{
    public class OccupationRepositorie : Repository<Occupation>, IOccupationRepositorie
    {
        public OccupationRepositorie(string identificator="IdOccupation") : base(identificator)
        {
        }

        public List<Occupation> SearchByName(string text)
        {
            var list = dbSet.Where(w=>w.OcupationName.Contains(text)).ToList();
            return list;
        }

        public List<Occupation> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.OcupationName.Contains(text))
                .OrderBy(w=> w.OcupationName)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
    }
}