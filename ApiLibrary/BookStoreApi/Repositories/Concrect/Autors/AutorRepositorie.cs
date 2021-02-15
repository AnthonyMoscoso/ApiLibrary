using BookStoreApi.Models;
using BookStoreApi.Models.Library;
using LibraryApiRest.Models;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApiRest.Repositories.Concrect
{
    public class AutorRepositorie  : Repositorie<Autor> , IAutorRepositorie
    {
    }
}