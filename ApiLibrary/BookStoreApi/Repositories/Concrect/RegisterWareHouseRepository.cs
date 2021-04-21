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
    public class RegisterWareHouseRepository : Repository<Register, RegisterWareHouseDto>, IRegisterWareHouseRepository
    {
        public RegisterWareHouseRepository(string identificator="idRegister") : base(identificator)
        {
        }

        public List<RegisterWareHouseDto> GetByWareHouse(string idWareHouse)
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse))
                .ToList();
            return mapper.Map<List<RegisterWareHouseDto>>(result);
        }

        public List<RegisterWareHouseDto> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse))
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<RegisterWareHouseDto>>(result);
        }
        public List<RegisterWareHouseDto> GetByWareHouse(string idWareHouse, DateTime date)
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) &&
                    DbFunctions.TruncateTime(date) == w.RegisterDate)
                      .ToList();
            return mapper.Map<List<RegisterWareHouseDto>>(result);
        }
        public List<RegisterWareHouseDto> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && 
            DbFunctions.TruncateTime(date) == w.RegisterDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<RegisterWareHouseDto>>(result);
        }

        public List<RegisterWareHouseDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd)
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) &&
                   DbFunctions.TruncateTime(dateStart) >= DbFunctions.TruncateTime( w.RegisterDate)  && 
                   DbFunctions.TruncateTime(dateEnd) <= DbFunctions.TruncateTime(dateEnd))
                     .ToList();
            return mapper.Map<List<RegisterWareHouseDto>>(result);
        }
        public List<RegisterWareHouseDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            var result = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) &&
                   DbFunctions.TruncateTime(dateStart) >= DbFunctions.TruncateTime(w.RegisterDate) &&
                   DbFunctions.TruncateTime(dateEnd) <= DbFunctions.TruncateTime(dateEnd))
                      .Skip((pag - 1) * element)
                      .Take(element)
                      .ToList();
            return mapper.Map<List<RegisterWareHouseDto>>(result);
        }

   

        public dynamic Insert(List<RegisterWareHouseDto> list)
        {
            string message = "";
            foreach (RegisterWareHouseDto dto in list)
            {
                var search = Context.Store.Find(dto.IdWareHouse);
                if (search != null)
                {
                    Register register = mapper.Map<Register>(dto);
                    register.Store = null;
                    dbSet.Add(register);
                    message += Save();
                    var query = string.Format("Insert into RegisterWareHouse values('{0}','{1}') ;", dto.IdWareHouse, dto.IdRegister);
                    Context.Database.ExecuteSqlCommand(query);
                    message += Save();
                }
                else
                {
                    message += "Error WareHouse with id " + dto.IdWareHouse + " was not found";
                }
            }
            return message;
        }

        public dynamic Update(List<RegisterWareHouseDto> list)
        {
            List<Register> registers = mapper.Map<List<Register>>(list);
            base.Update(registers);
            return Save();
        }
    }
}