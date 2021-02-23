using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Editorials;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Editorials
{
    public class EditorialRepositorie : Repositorie<Editorial>, IEditorialRepositorie
    {
        public EditorialRepositorie(string identificator="IdEditorial") : base(identificator)
        {
        }
    }
}