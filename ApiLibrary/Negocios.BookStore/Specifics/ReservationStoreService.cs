using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Models.Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.DBAccess.Ado;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Logger.Abstracts;

namespace Business.BookStoreServices.Specifics
{
    public class ReservationStoreService : ServiceMapperBase<ReservationStoreDto, ReservationStore>, IReservationStoreService
    {
        public ReservationStoreService(IReservationStoreRepository repository) : base(repository)
        {
        }

        public int Count(string idStore)
        {
            throw new NotImplementedException();
        }

        public int Count(string idStore, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationStoreDto> GetByStore(string idStore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationStoreDto> GetByStore(string idStore, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationStoreDto> GetByStore(string idStore, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationStoreDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
