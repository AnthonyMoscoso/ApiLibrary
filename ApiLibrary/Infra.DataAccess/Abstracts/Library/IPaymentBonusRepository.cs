using Models.Ado.Library;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IPaymentBonusRepository : IRepository<PaymentBonus>
    {
        IEnumerable<PaymentBonus> SearchByName(string text);
        IEnumerable<PaymentBonus> SearchByName(string text, int pag, int element);
    }
}
