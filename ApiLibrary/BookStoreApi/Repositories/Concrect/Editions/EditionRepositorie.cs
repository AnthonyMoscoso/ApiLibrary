using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Editions;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Editions
{
    public class EditionRepositorie : Repositorie<Edition>,IEditionRepositorie
    {
    }
}