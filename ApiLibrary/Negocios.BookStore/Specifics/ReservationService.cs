using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Ado.Library.Specifics;
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

    public class ReservationService : ServiceMapperBase<ReservationDto, Reservation>, IReservationService
    {
        public ReservationService(ReservationRepository repository) : base(repository)
        {
        }

        public double CountByBook(string idBook)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetByBook(string idBook)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetByBook(string idBook, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetByClient(string idClient)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetByClient(string idClient, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetByClient(string idClient, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetByClient(string idClient, DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetByDate(DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetByDate(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetByFinalizedDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetByFinalizedDate(DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetCancel()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetCancel(int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetFinalized()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetFinalized(int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetNotFinalized()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservationDto> GetNotFinalized(int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
