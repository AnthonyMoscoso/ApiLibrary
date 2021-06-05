﻿using Ado.Library;
using Models.Ado.Library;
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
    public class RolService : ServiceMapperBase<RolDto, Rol>, IRolService
    {
        public RolService(IRolRepository repository) : base(repository)
        {
        }

        public IEnumerable<RolDto> SearchByName(string text)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RolDto> SearchByName(string text, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}