using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Receptions;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Receptions
{
    public class ReceptionRepositorie : Repositorie<Reception> , IReceptionRepositorie
    {
    }
}