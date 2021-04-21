using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Registers;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Registers
{
    public class RegisterRepositorie : Repository<Register,RegisterDto>, IRegisterRepositorie
    {
        public RegisterRepositorie(string identificator="IdRegister") : base(identificator)
        {
        }
        public List<RegisterDto> GetByDate(DateTime date)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date)).ToList();
            return mapper.Map<List<RegisterDto>>(result);
        }
        public List<RegisterDto> GetByDate(DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) == DbFunctions.TruncateTime(date))
                .OrderBy( w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<RegisterDto>>(result);
        }
        public List<RegisterDto> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            var result = dbSet.Where(w => (DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( dateStart))
            && (DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime(dateEnd))).ToList();
            return mapper.Map<List<RegisterDto>>(result);
        }
        public List<RegisterDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            var result = dbSet.Where(w => ( DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( dateStart))
            && (DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime( dateEnd.Date)))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<RegisterDto>>(result);
        }

        public List<RegisterDto> GetByStore(string idStore)
        {
            var result = dbSet.Where(w=> w.Store.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<RegisterDto>>(result);
        }

        public List<RegisterDto> GetByStore(string idStore, int pag, int element)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<RegisterDto>>(result);
        }

        public List<RegisterDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w=>w.Store.IdStore.Equals(idStore) && DbFunctions.TruncateTime( w.RegisterDate) == DbFunctions.TruncateTime(date))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<RegisterDto>>(result);
        }

        public List<RegisterDto> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore) && DbFunctions.TruncateTime( w.CreateDate) >=  DbFunctions.TruncateTime( dateStart) 
            && DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime( dateEnd))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<RegisterDto>>(result);
        }

        public List<RegisterDto> GetByWareHouse(string idWareHouse)
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse)).ToList();
            return mapper.Map<List<RegisterDto>>(result);
        }

        public List<RegisterDto> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<RegisterDto>>(result);
        }

        public List<RegisterDto> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element )
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) 
            && DbFunctions.TruncateTime( w.RegisterDate) == DbFunctions.TruncateTime(date))
                .OrderBy(w=>w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<RegisterDto>>(result);
        }

        public List<RegisterDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) 
            && DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( dateStart)
            && DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime( dateEnd))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<RegisterDto>>(result);
        }
    }
}