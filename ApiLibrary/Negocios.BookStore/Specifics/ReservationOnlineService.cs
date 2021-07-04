using Ado.Library;
using Models.Ado.Library;
using Models.Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.DBAccess.Ado;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Specifics
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
