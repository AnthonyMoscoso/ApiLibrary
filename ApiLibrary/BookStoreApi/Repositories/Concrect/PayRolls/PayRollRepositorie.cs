using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.PayRolls;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.PayRolls
{
    public class PayRollRepositorie : Repositorie<PayRoll> ,IPayRollRepositorie
    {
    }
}