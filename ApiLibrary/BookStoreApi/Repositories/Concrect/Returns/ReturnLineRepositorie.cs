using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Returns;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Returns
{
    public class ReturnLineRepositorie : Repositorie<ReturnLine>, IReturnLineRepositorie
    {
        public ReturnLineRepositorie(string identificator="IdReturnLine") : base(identificator)
        {
        }
    }
}