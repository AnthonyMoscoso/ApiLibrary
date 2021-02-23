using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Registers;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Registers
{
    public class RegisterLineRepositorie : Repositorie<RegisterLine>, IRegisterLineRepositorie
    {
        public RegisterLineRepositorie(string identificator="IdRegisterLine") : base(identificator)
        {
        }
    }
}