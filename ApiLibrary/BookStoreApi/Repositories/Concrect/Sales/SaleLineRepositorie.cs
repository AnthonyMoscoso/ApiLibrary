using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Sales;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Sales
{
    public class SaleLineRepositorie : Repositorie<SaleLine> ,ISaleLineRepositorie
    {
    }
}