﻿using Models.Ado.Library;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.DBAccess.Ado;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Specifics
{
    public class ProviderService : ServiceMapperBase<ProviderDto, Providers>, IProviderService
    {
        public ProviderService(IRepository<Providers> repository) : base(repository)
        {
        }

        public IEnumerable<Providers> SearchByName(string text)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Providers> SearchByName(string text, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}