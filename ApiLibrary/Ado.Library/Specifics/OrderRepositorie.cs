using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Order
{
    public class OrderRepositorie : Repository<Orders, OrderDto>, IOrderRepositorie
    {
        public OrderRepositorie(string identificator="IdOrder") : base(identificator)
        {
        }

        public new dynamic Update(List<Orders> list)
        {
            string message = "";
            foreach (Orders o in list)
            {
                if (o.OrderLine.Count > 0)
                {
                    foreach (OrderLine line in o.OrderLine)
                    {
                        var searchLine = Context.OrderLine.Find(line.IdOrderLine);
                        if (searchLine != null)
                        {
                            if (!searchLine.LastUpdateDate.Equals(line.LastUpdateDate))
                            {
                                Context.OrderLine.Attach(line);
                                Context.Entry(line).State = EntityState.Modified;
                            }
                        }
                    }
                 
                }

                dbSet.Attach(o);
                Context.Entry(o).State = EntityState.Modified;
                message += Save();
            }
            return Save();
        }

        public new dynamic Delete(List<string>ids)
        {
            string message = "";
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search!=null)
                {
                    List<OrderLine> lines = search.OrderLine.ToList(); ;
                    foreach (OrderLine line in lines)
                    {
                        Context.OrderLine.Remove(line);
                    }
                    dbSet.Remove(search);
                    message += Save();
                }
                else
                {
                    message += "\nNo was found any Order with this id "+id;
                }
                
              
            }
          
            return message;
        }

     /*   public new List<OrderDto> Get()
        {
            var list = dbSet.ToList();
            return mapper.Map<List<OrderDto>>(list);
        }

        public new List<OrderDto> Get(int element,int pag)
        {
            var list = dbSet
                .OrderBy(w=> w.CreateDate)
                .Skip((pag-1)*element)
                .Take(element)
                .ToList();
            return mapper.Map<List<OrderDto>>(list);
        }*/
        public List<OrderDto> GetByDate(DateTime date)
        {
            var list = dbSet.Where(w=> DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date)).ToList();
            return mapper.Map<List<OrderDto>>(list);
        }

        public List<OrderDto> GetByDate(DateTime date, int pag, int element)
        {
            var list = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date))
                .OrderBy(w=>w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<OrderDto>>(list);
        }

        public List<OrderDto> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            var list = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(dateStart) 
            && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(dateEnd)).ToList();
            return mapper.Map<List<OrderDto>>(list);
        }

        public List<OrderDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            var list = dbSet.Where(w => w.CreateDate >= dateStart && w.CreateDate <= dateEnd)
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<OrderDto>>(list);
        }


        public List<OrderDto> GetByStore(string idStore)
        {
            var list = dbSet.Where(w=>w.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<OrderDto>>(list);
        }

        public List<OrderDto> GetByStore(string idStore, int pag, int element)
        {
            var list = dbSet.Where(w => w.IdStore.Equals(idStore))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<OrderDto>>(list);
        }
        public List<OrderDto> GetByStore(string idStore, DateTime date)
        {
            var list = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date) && w.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<OrderDto>>(list);
        }

        public List<OrderDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
           var list= dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date) && w.IdStore.Equals(idStore))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<OrderDto>>(list);
        }

        public List<OrderDto> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd)
        {
            var list = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( dateStart) 
            && DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime(dateEnd)
            && w.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<OrderDto>>(list);
        }

        public List<OrderDto> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            var list = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( dateStart) 
            && DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime( dateEnd) 
            && w.IdStore.Equals(idStore))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<OrderDto>>(list);
        }


        public List<OrderDto> GetByWareHouse(string idWareHouse, DateTime date)
        {
            var list = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) 
            && DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date))
                .ToList();
            return mapper.Map<List<OrderDto>>(list);
        }

        public List<OrderDto> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            var list = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) 
            && DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag-1)*element)
                .Take(element)
                .ToList();
            return mapper.Map<List<OrderDto>>(list);
        }

        public List<OrderDto> GetByWareHouse(string idWareHouse)
        {
            var list = dbSet.Where(w => w.IdWareHouse.Equals(idWareHouse)).ToList();
            return mapper.Map<List<OrderDto>>(list);
        }

        public List<OrderDto> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            var list = dbSet.Where(w => w.IdWareHouse.Equals(idWareHouse))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<OrderDto>>(list);
        }

        public List<OrderDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd)
        {
            var list = dbSet.Where(w => w.IdWareHouse.Equals(idWareHouse)
            && DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( dateStart)
            && DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime( dateEnd)).ToList();
            return mapper.Map<List<OrderDto>>(list);
        }

        public List<OrderDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            var list = dbSet.Where(w => w.IdWareHouse.Equals(idWareHouse) 
            && DbFunctions.TruncateTime( w.CreateDate) 
            >= DbFunctions.TruncateTime( dateStart) 
            && DbFunctions.TruncateTime( w.CreateDate) 
            <=  DbFunctions.TruncateTime( dateEnd))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<OrderDto>>(list);
        }
    }
}