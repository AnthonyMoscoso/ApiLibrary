using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Shippings;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Shippings
{
    public class ShippingLineRepositorie : Repositorie<ShippingLine>, IShippingLineRepositorie
    {
        public ShippingLineRepositorie(string identificator="IdShippingLine") : base(identificator)
        {
        }
    }
}