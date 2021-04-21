﻿using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Sales
{
    interface IProviderRepository : IRepository<Providers>
    {
        List<Providers> SearchByName(string text);
        List<Providers> SearchByName( string text,int pag,int element);
    }
}