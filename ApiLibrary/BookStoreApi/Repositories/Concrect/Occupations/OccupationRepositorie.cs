using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Occupations;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Occupations
{
    public class OccupationRepositorie : Repositorie<Occupation>, IOccupationRepositorie
    {
        public OccupationRepositorie(string identificator="IdOccuppation") : base(identificator)
        {
        }
    }
}