using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Returns;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Returns
{
    public class ReturnLineRepositorie : Repository<ReturnLine,ReturnLineDto>, IReturnLineRepositorie
    {
        public ReturnLineRepositorie(string identificator="IdReturnLine") : base(identificator)
        {
        }

        public List<ReturnLine> GetByReturn(string idReturn)
        {
            return dbSet.Where(w => w.IdReturn.Equals(idReturn)).ToList();
        }
    }
}