using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Payments
{
    interface IPaymentBonusRepositorie : IRepositorie <PaymentBonus>
    {
        List<PaymentBonus> SearchByName(string text);
        List<PaymentBonus> SearchByName(string text,int pag,int element);
    }
}
