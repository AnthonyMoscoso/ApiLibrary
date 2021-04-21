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
    public class RegisterLineRepository : Repository<RegisterLine,RegisterLineDto>, IRegisterLineRepository
    {
        public RegisterLineRepository(string identificator="IdRegisterLine") : base(identificator)
        {
        }

        public List<RegisterLineDto> GetByRegister(string idRegister)
        {
            var list= dbSet.Where(w => w.IdRegister.Equals(idRegister)).ToList();
            return mapper.Map<List<RegisterLineDto>>(list);
        }
    }
}