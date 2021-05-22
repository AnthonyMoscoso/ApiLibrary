using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IPaymentBonusRepositorie : IRepository <PaymentBonus>
    {
        List<PaymentBonus> SearchByName(string text);
        List<PaymentBonus> SearchByName(string text,int pag,int element);
    }
}
