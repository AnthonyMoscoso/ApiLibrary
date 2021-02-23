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
    }
}