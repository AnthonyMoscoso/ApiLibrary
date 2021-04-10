using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Registers;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Registers
{
    public class RegisterLineRepositorie : Repository<RegisterLine,RegisterLineDto>, IRegisterLineRepositorie
    {
        public RegisterLineRepositorie(string identificator="IdRegisterLine") : base(identificator)
        {
        }

        public List<RegisterLine> GetByRegister(string idRegister)
        {
            return dbSet.Where(w => w.IdRegister.Equals(idRegister)).ToList();
        }
    }
}