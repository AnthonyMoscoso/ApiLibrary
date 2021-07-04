using Models.Ado.Library;
using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IPaymentBonusService : IServices<PaymentBonusDto>
    {
        IEnumerable<PaymentBonus> SearchByName(string text);
        IEnumerable<PaymentBonus> SearchByName(string text, int pag, int element);
    }
}
