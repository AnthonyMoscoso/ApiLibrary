using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Persons;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Persons
{
    public class SocieRepositorie : Repositorie<Socie>, ISocieRepositorie
    {
        public SocieRepositorie(string identificator="IdSocie") : base(identificator)
        {
        }
    }
}