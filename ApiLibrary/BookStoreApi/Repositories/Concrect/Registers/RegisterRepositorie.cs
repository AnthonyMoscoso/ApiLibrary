﻿using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Registers;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Registers
{
    public class RegisterRepositorie : Repositorie<Register>, IRegisterRepositorie
    {
        public RegisterRepositorie(string identificator="IdRegister") : base(identificator)
        {
        }
    }
}