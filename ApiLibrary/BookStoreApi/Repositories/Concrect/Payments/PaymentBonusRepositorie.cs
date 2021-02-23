using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Payments;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Payments
{
    public class PaymentBonusRepositorie : Repositorie<PaymentBonus>, IPaymentBonusRepositorie
    {
        public PaymentBonusRepositorie(string identificator="IdPaymentBonus") : base(identificator)
        {
        }
    }
}