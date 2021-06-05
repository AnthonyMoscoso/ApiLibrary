using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.DBAccess.Ado;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Specifics
{
    public class ReceptionService : ServiceMapperBase<ReceptionDto, Reception>, IReceptionService
    {
        public ReceptionService(IReceptionRepository repository) : base(repository)
        {
        }

        public IEnumerable<ReceptionDto> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceptionDto> GetByDate(DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceptionDto> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceptionDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceptionDto> GetByOrder(string idOrder)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceptionDto> GetByPurchase(string idPurchase)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceptionDto> GetByStore(string idStore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceptionDto> GetByStore(string idStore, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceptionDto> GetByStore(string idStore, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceptionDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
