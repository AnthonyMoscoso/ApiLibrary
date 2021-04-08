using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Order;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Order
{
    public class OrderLineRepositorie : Repository<OrderLine>, IOrderLineRepositorie
    {
        public OrderLineRepositorie(string identificator="IdOrderLine") : base(identificator)
        {
        }

        public List<OrderLine> GetByOrder(string idOrder)
        {
            return dbSet.Where(w=>w.IdOrder.Equals(idOrder)).ToList();
        }
    }
}