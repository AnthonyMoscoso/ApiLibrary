using Ado.Library;
using Models.Ado.Library;
using Models.Models.Dtos;
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
    public class ReservationOnlineService : ServiceMapperBase<ReservationOnlineDto, ReservationOnline>, IReservationOnlineService
    {
        public ReservationOnlineService(IReservationOnlineRepository repository) : base(repository)
        {
        }

        public int Count(string idWareHouse)
        {
            throw new NotImplementedException();
        }

        public int Count(string idWareHouse, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationOnlineDto> GetReservations(string idWareHouse)
        {
            throw new NotImplementedException();
        }
    }
}
