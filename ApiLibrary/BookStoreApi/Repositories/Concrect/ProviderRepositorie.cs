using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Sales;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Provide
{
    public class ProviderRepositorie : Repository<Providers,ProviderDto>, IProviderRepository
    {
        public ProviderRepositorie(string identificator="IdProvider") : base(identificator)
        {
        }

        public List<Providers> SearchByName(string text)
        {
            return dbSet.Where(w => w.ProviderName.Contains(text)).ToList();
        }

        public List<Providers> SearchByName(string text,int pag, int element)
        {
            return dbSet.Where(w => w.ProviderName.Contains(text))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1)*element).Take(element).ToList();
        }
    }
}