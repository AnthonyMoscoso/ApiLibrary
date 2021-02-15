using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Permits;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Permits
{
    public class PermitRepositorie : Repositorie<Permit> ,IPermitRepositorie
    {
    }
}