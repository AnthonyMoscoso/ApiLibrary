﻿using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Payments
{
    public class PaymentBonusRepositorie : Repository<PaymentBonus,PaymentBonusDto>, IPaymentBonusRepositorie
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