using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{
    public class PaymentBonusRepository : Repository<PaymentBonus>, IPaymentBonusRepository
    {
        public PaymentBonusRepository(BookStoreEntities context,string identificator="IdPaymentBonus") : base(context,identificator)
        {
        }

        public IEnumerable<PaymentBonus> SearchByName(string text)
        {
            return dbSet.Where(w => w.BonusDescription.Contains(text));
        }

        public IEnumerable<PaymentBonus> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.BonusDescription.Contains(text))
                .OrderBy(w => w.BonusTittle)
                .Skip((pag - 1) * element)
                .Take(element);
        }
    }
}