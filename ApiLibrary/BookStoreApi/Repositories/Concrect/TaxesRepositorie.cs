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

        public List<Taxes> GetByType(int type)
        {
            return dbSet.Where(w => w.TaxType == type).ToList();
        }

        public List<Taxes> GetByType(int type, int pag, int element)
        {
            return dbSet.Where(w => w.TaxType == type).Skip((pag - 1) * element).Take(element).ToList(); 
        }

        public List<Taxes> SearchByName(string text)
        {
            return dbSet.Where(w => w.TaxTittle.Contains(text)).ToList();
        }

        public List<Taxes> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.TaxTittle.Contains(text)).Skip((pag - 1) * element).Take(element).ToList(); 
        }
    }
}