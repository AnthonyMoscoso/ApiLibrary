﻿using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Registers
{
    interface IRegisterLineRepositorie : IRepositorie<RegisterLine>
    {
        List<RegisterLine> GetByRegister(string idRegister);
    }
}