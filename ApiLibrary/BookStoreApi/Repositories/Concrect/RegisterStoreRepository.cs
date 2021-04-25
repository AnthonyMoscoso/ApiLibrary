using BookStoreApi.Models.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect
{
    public class RegisterStoreRepository : Repository<Register, RegisterStoreDto> , IRegisterStoreRepository
    {
        public RegisterStoreRepository(string identificator="IdRegister") : base(identificator)
        {
        }

        public List<RegisterStoreDto> GetByStore(string idStore)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<RegisterStoreDto>>(result);
        }

        public List<RegisterStoreDto> GetByStore(string idStore, int pag, int element)
        {
            var result = dbSet.Where(w=> w.Store.IdStore.Equals(idStore))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag-1)*element)
                .Take(element)
                .ToList();
            return mapper.Map<List<RegisterStoreDto>>(result);
        }

        public List<RegisterStoreDto> GetByStore(string idStore, DateTime date)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore)
            && DbFunctions.TruncateTime(w.RegisterDate) == DbFunctions.TruncateTime(date))
                .ToList();
            return mapper.Map<List<RegisterStoreDto>>(result);
        }

        public List<RegisterStoreDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore)
            && DbFunctions.TruncateTime(w.RegisterDate) == DbFunctions.TruncateTime(date))
             .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<RegisterStoreDto>>(result);
        }

        public List<RegisterStoreDto> GetByStore(string idStore, DateTime start, DateTime end)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore)&& 
            (DbFunctions.TruncateTime(w.RegisterDate) >= start && DbFunctions.TruncateTime(w.RegisterDate) <= end))
                .ToList();
            return mapper.Map<List<RegisterStoreDto>>(result);
        }

        public List<RegisterStoreDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore) &&
            (DbFunctions.TruncateTime(w.RegisterDate) >= start && DbFunctions.TruncateTime(w.RegisterDate) <= end))
             .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<RegisterStoreDto>>(result);
        }

        public dynamic Insert(List<RegisterStoreDto> list)
        {
            string message = "";
            foreach (RegisterStoreDto dto in list)
            {
                var search = Context.Store.Find(dto.IdStore);
                if (search!=null)
                {
                    Register register = mapper.Map<Register>(dto);
                    register.Store = null;
                    dbSet.Add(register);
                    message += Save();
                    var query = string.Format("Insert into RegisterStore values('{0}','{1}') ;",  dto.IdStore,dto.IdRegister);
                    Context.Database.ExecuteSqlCommand(query);
                    message += Save();
                }
                else
                {
                    message += "Error store with id " + dto.IdStore +" was not found";
                }
            }
            return message;
        }

        public dynamic Update(List<RegisterStoreDto> list)
        {
            List<Register> registers = mapper.Map<List<Register>>(list);
            base.Update(registers);
            return Save();
        }

        new public List<RegisterStoreDto> Get()
        {
            var result = dbSet.Where(w=> w.Store!=null).ToList();
            return mapper.Map<List<RegisterStoreDto>>(result);
        }
    }
}