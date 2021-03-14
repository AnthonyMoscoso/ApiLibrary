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

        public List<PaymentBonus> SearchByName(string text)
        {
            return dbSet.Where(w => w.BonusDescription.Contains(text)).ToList() ;
        }

        public List<PaymentBonus> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.BonusDescription.Contains(text))
                .OrderBy(w=> w.BonusTittle)
                .Skip((pag - 1) * element)
                .Take(element).ToList(); 
        }
    }
}