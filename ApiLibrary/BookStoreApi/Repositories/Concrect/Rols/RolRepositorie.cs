using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Rols;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Rols
{
    public class RolRepositorie : Repositorie<Rol> ,IRolRepositorie
    {
    }
}