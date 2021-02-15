using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Stores;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Stores
{
    public class StoreRepositorie : Repositorie<Store> ,IStoreRepositorie
    {
    }
}