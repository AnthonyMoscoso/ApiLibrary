using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Receptions;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Receptions
{
    public class ReceptionLineRepositorie : Repositorie<ReceptionLine>, IReceptionLineRepositorie
    {
        public ReceptionLineRepositorie(string identificator="IdReceptionLine") : base(identificator)
        {
        }

        public List<ReceptionLine> GetByReception(string idReception)
        {
            return dbSet.Where(w => w.IdReception.Equals(idReception)).ToList();
        }
    }
}