using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Reservations;
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
        readonly IReservationRepository _repository = new ReservationRepository();

        #region Generics 
        [HttpGet]
        [Route("Count")]
        public IHttpActionResult Count()
        {
            return Ok(_repository.Count());
        }
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

        [HttpGet]
        public IHttpActionResult GetList(string ids)
        {
            return Ok(_repository.GetList(ids));
        }

        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int pag)
        {
            return Ok(_repository.Get(element, pag));
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

        #endregion

        #region Count 
        [HttpGet]
        [Route("Count")]
        public IHttpActionResult Count(string idBook)
        {
            return Ok(_repository.CountByBook(idBook));
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
        public IHttpActionResult GetByBook(string idBook,int pag,int element)
        {
            return Ok(_repository.GetByBook(idBook,pag,element));
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

      
        #endregion

        #region Finalized 
       
        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized(int pag,int element)
        {
            return Ok(_repository.GetFinalized(pag,element));
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
        [Route("Cliente/{id}")]
        public IHttpActionResult GetByCliente(string idCliente)
        {
            return Ok(_repository.GetByClient(idCliente));
        }

        [HttpGet]
        [Route("Cliente/{id}")]
        public IHttpActionResult GetByCliente(string idCliente,int pag,int element)
        {
            return Ok(_repository.GetByClient(idCliente,pag,element));
        }

        [HttpGet]
        [Route("Cliente/{id}")]
        public IHttpActionResult GetByCliente(string idCliente,DateTime start ,DateTime end)
        {
            return Ok(_repository.GetByClient(idCliente,start,end));
        }
        [HttpGet]
        [Route("Cliente/{id}")]
        public IHttpActionResult GetByCliente(string idCliente, DateTime start, DateTime end, int pag, int element)
        {
            return Ok(_repository.GetByClient(idCliente, start, end,pag,element));
        }
        #endregion

        
        
    }
}
