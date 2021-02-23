using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Taxe;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Taxe
{
    public class TaxesRepositorie : Repositorie<Taxes>, ITaxesRepositorie
    {
        public TaxesRepositorie(string identificator="IdTaxes") : base(identificator)
        {
        }
    }
}