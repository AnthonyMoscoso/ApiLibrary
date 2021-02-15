using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Order;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Order
{
    public class OrderLineRepositorie : Repositorie<OrderLine>, IOrderLineRepositorie
    {
    }
}