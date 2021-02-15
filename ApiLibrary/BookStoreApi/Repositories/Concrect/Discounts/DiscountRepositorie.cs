using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Discounts;
using LibraryApiRest.Repositories.Concrect;

namespace BookStoreApi.Repositories.Concrect.Discounts
{
    public class DiscountRepositorie : Repositorie<Discount>,IDiscountRepositorie
    {
    }
}