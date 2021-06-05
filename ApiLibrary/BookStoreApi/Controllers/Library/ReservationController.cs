using System;
using System.Web.Http;
using Negocios.BookStoreServices.Abstracts;
using Ado.Library.Specifics;
using Negocios.BookStoreServices.Specifics;
using Models.Dtos;
using System.Collections.Generic;

namespace Models.Controllers.Library.Reservations
{
    [RoutePrefix("Api/Reservation")]
    public class ReservationController : ApiController
    {
        readonly IReservationService _service ;

        public ReservationController(IReservationService service)
        {
            _service = service;
        }

        #region Generics 
        [HttpGet]
        [Route("Count")]
        public IHttpActionResult Count()
        {
            return Ok(_service.Count());
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_service.Get());
        }

        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return Ok(_service.Get(id));
        }

        [HttpGet]
        public IHttpActionResult GetList(string ids)
        {
            return Ok(_service.GetList(ids));
        }

        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int pag)
        {
            return Ok(_service.Get(element, pag));
        }
       [HttpPost]
        public IHttpActionResult Post(List<ReservationDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<ReservationDto> list)
        {
            return Ok(_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_service.Delete(ids));
        }

        #endregion

        #region Count 
        [HttpGet]
        [Route("Count")]
        public IHttpActionResult Count(string idBook)
        {
            return Ok(_service.CountByBook(idBook));
        }

        #endregion

        #region Book
        [HttpGet]
        [Route("Book")]
        public IHttpActionResult GetByBook(string idBook)
        {
            return Ok(_service.GetByBook(idBook));
        }
       
        [HttpGet]
        [Route("Book")]
        public IHttpActionResult GetByBook(string idBook,int pag,int element)
        {
            return Ok(_service.GetByBook(idBook,pag,element));
        }
        
        #endregion

        #region Date
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date)
        {
            return Ok(_service.GetByDate(date));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date,int pag,int element)
        {
            return Ok(_service.GetByDate(date,pag,element));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start,DateTime end)
        {
            return Ok(_service.GetByDate(start,end));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            return Ok(_service.GetByDate(start, end,pag,element));
        }
        #endregion

        #region Finalized Date
        [HttpGet]
        [Route("FinalizedDate")]
        public IHttpActionResult GetByFinalizedDate(DateTime date)
        {
            return Ok(_service.GetByFinalizedDate(date));
        }

        [HttpGet]
        [Route("FinalizedDate")]
        public IHttpActionResult GetByFinalizedDate(DateTime date,int pag,int element)
        {
            return Ok(_service.GetByFinalizedDate(date,pag,element));
        }
      
        #endregion

        #region Cancel
        [HttpGet]
        [Route("Cancel")]
        public IHttpActionResult GetCancel()
        {
            return Ok(_service.GetCancel());
        }
        [HttpGet]
        [Route("Cancel")]
        public IHttpActionResult GetCancel(int pag,int element)
        {
            return Ok(_service.GetCancel(pag,element));
        }

      
        #endregion

        #region Finalized 
       
        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized(int pag,int element)
        {
            return Ok(_service.GetFinalized(pag,element));
        }

      
        #endregion

        #region Not Finalized 
        [HttpGet]
        [Route("NotFinalized")]
        public IHttpActionResult GetNotFinalized()
        {
            return Ok(_service.GetNotFinalized());
        }

        [HttpGet]
        [Route("NotFinalized")]
        public IHttpActionResult GetNotFinalized(int pag, int element)
        {
            return Ok(_service.GetNotFinalized(pag, element));
        }

        [HttpGet]
        [Route("Cliente/{id}")]
        public IHttpActionResult GetByCliente(string idCliente)
        {
            return Ok(_service.GetByClient(idCliente));
        }

        [HttpGet]
        [Route("Cliente/{id}")]
        public IHttpActionResult GetByCliente(string idCliente,int pag,int element)
        {
            return Ok(_service.GetByClient(idCliente,pag,element));
        }

        [HttpGet]
        [Route("Cliente/{id}")]
        public IHttpActionResult GetByCliente(string idCliente,DateTime start ,DateTime end)
        {
            return Ok(_service.GetByClient(idCliente,start,end));
        }
        [HttpGet]
        [Route("Cliente/{id}")]
        public IHttpActionResult GetByCliente(string idCliente, DateTime start, DateTime end, int pag, int element)
        {
            return Ok(_service.GetByClient(idCliente, start, end,pag,element));
        }
        #endregion

        
        
    }
}
