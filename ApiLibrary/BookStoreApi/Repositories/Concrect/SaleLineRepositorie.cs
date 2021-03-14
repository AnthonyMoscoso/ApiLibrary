using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Sales;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Sales
{
    public class SaleLineRepositorie : Repositorie<SaleLine>, ISaleLineRepositorie
    {
        public SaleLineRepositorie(string identificator="IdSaleLine") : base(identificator)
        {
        }

        public List<SaleLine> GetBySale(string idSale)
        {
            return dbSet.Where(w => w.IdSale.Equals(idSale)).ToList();
        }
    }
}