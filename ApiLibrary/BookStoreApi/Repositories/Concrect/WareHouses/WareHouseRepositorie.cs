using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.WareHouses;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.WareHouses
{
    public class WareHouseRepositorie : Repositorie<WareHouse> ,IWareHouseRepositorie
    {
    }
}