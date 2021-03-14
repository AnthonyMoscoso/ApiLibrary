using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Reservations
{
    [RoutePrefix("Api/Reservation")]
    public class ReservationController : ApiController
    {
        public ReservationRepositorie _repository = new ReservationRepositorie();

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repository.Get());
        }
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return Ok(_repository.Get(id));
        }

        #region Count 
        [HttpGet]
        [Route("Count")]
        public IHttpActionResult Count(string idBook)
        {
            return Ok(_repository.GetCountBook(idBook));
        }
        [HttpGet]
        [Route("Count")]
        public IHttpActionResult Count(string idBook,string idStore)
        {
            return Ok(_repository.GetCountBook(idBook,idStore));
        }
        #endregion

        #region Book
        [HttpGet]
        [Route("Book")]
        public IHttpActionResult GetByBook(string idBook)
        {
            return Ok(_repository.GetByBook(idBook));
        }
        [HttpGet]
        [Route("Book")]
        public IHttpActionResult GetByBook(string idBook,string idStore)
        {
            return Ok(_repository.GetByBook(idBook,idStore));
        }
        [HttpGet]
        [Route("Book")]
        public IHttpActionResult GetByBook(string idBook,int pag,int element)
        {
            return Ok(_repository.GetByBook(idBook,pag,element));
        }
        [HttpGet]
        [Route("Book")]
        public IHttpActionResult GetByBook(string idBook, string idStore, int pag, int element)
        {
            return Ok(_repository.GetByBook(idBook, idStore,pag,element));
        }
        #endregion

        #region Date
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date)
        {
            return Ok(_repository.GetByDate(date));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date,int pag,int element)
        {
            return Ok(_repository.GetByDate(date,pag,element));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start,DateTime end)
        {
            return Ok(_repository.GetByDate(start,end));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            return Ok(_repository.GetByDate(start, end,pag,element));
        }
        #endregion

        #region Store
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore)
        {
            return Ok(_repository.GetByStore(idStore));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore,int pag,int element)
        {
            return Ok(_repository.GetByStore(idStore,pag,element));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore,DateTime date)
        {
            return Ok(_repository.GetByStore(idStore,date));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore,DateTime date,int pag,int element)
        {
            return Ok(_repository.GetByStore(idStore,date,pag,element));
        }
        #endregion

        #region Finalized Date
        [HttpGet]
        [Route("FinalizedDate")]
        public IHttpActionResult GetByFinalizedDate(DateTime date)
        {
            return Ok(_repository.GetByFinalizedDate(date));
        }

        [HttpGet]
        [Route("FinalizedDate")]
        public IHttpActionResult GetByFinalizedDate(DateTime date,int pag,int element)
        {
            return Ok(_repository.GetByFinalizedDate(date,pag,element));
        }
        [HttpGet]
        [Route("FinalizedDate")]
        public IHttpActionResult GetByFinalizedDate(DateTime date, string idStore)
        {
            return Ok(_repository.GetByFinalizedDate(date, idStore));
        }
        [HttpGet]
        [Route("FinalizedDate")]
        public IHttpActionResult GetByFinalizedDate(DateTime date,string idStore, int pag, int element)
        {
            return Ok(_repository.GetByFinalizedDate(date,idStore, pag, element));
        }
        #endregion

        #region Cancel
        [HttpGet]
        [Route("Cancel")]
        public IHttpActionResult GetCancel()
        {
            return Ok(_repository.GetCancel());
        }
        [HttpGet]
        [Route("Cancel")]
        public IHttpActionResult GetCancel(int pag,int element)
        {
            return Ok(_repository.GetCancel(pag,element));
        }
        [HttpGet]
        [Route("Cancel")]
        public IHttpActionResult GetCancel(string idStore)
        {
            return Ok(_repository.GetCancel(idStore));
        }
        [HttpGet]
        [Route("Cancel")]
        public IHttpActionResult GetCancel(string idStore ,int pag, int element)
        {
            return Ok(_repository.GetCancel(idStore,pag, element));
        }
        #endregion

        #region Finalized 
        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized()
        {
            return Ok(_repository.GetFinalized());
        }

        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized(int pag,int element)
        {
            return Ok(_repository.GetFinalized(pag,element));
        }

        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized(string idStore)
        {
            return Ok(_repository.GetFinalized(idStore));
        }

        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized(string idStore,int pag,int element)
        {
            return Ok(_repository.GetFinalized(idStore,pag,element));
        }
        #endregion

        #region Not Finalized 
        [HttpGet]
        [Route("NotFinalized")]
        public IHttpActionResult GetNotFinalized()
        {
            return Ok(_repository.GetNotFinalized());
        }

        [HttpGet]
        [Route("NotFinalized")]
        public IHttpActionResult GetNotFinalized(int pag, int element)
        {
            return Ok(_repository.GetNotFinalized(pag, element));
        }

        [HttpGet]
        [Route("NotFinalized")]
        public IHttpActionResult GetNotFinalized(string idStore)
        {
            return Ok(_repository.GetNotFinalized(idStore));
        }

        [HttpGet]
        [Route("NotFinalized")]
        public IHttpActionResult GetNotFinalized(string idStore, int pag, int element)
        {
            return Ok(_repository.GetNotFinalized(idStore, pag, element));
        }
        #endregion

        [HttpPost]
        [Route("List")]
        public IHttpActionResult Get(List<string> ids)
        {
            return Ok(_repository.Get(ids));
        }

        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int page)
        {
            return Ok(_repository.Get(element, page));
        }
        [HttpPost]
        public IHttpActionResult Post(List<Reservation> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Reservation> list)
        {
            return Ok(_repository.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_repository.Delete(ids));
        }
    }
}
