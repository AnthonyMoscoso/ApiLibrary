using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Returns;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Returns
{
    public class ReturnSaleRepositorie : Repositorie<ReturnSale> ,IReturnSaleRepositorie
    {
    }
}