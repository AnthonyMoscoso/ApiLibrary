using Ado.Library;
using Models.Models.Dtos;
using Models.Repositories.Abstract;
using Ado.Library.Specifics;
using Negocios.BookStoreServices.Specifics;
using Negocios.BookStoreServices.Abstracts;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Models.Controllers.Library
{
    [RoutePrefix("api/ReservationStore")]
    [Authorize]
    public class ReservationStoreController : ApiController
    {
        readonly IReservationStoreService _service ;

        public ReservationStoreController(IReservationStoreService service)
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
        public IHttpActionResult Insert(List<ReservationStoreDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Update(List<ReservationStoreDto> list)
        {

            return Ok(_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_service.Delete(ids));
        }
        #endregion

       #region Store
        [HttpGet]
        [Route("Store/{idStore}")]
        public IHttpActionResult GetByStore(string idStore)
        {
            return Ok(_service.GetByStore(idStore));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore,int pag,int element)
        {
            return Ok(_service.GetByStore(idStore,pag,element));
        }

        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore, DateTime start, DateTime end)
        {
            return Ok(_service.GetByStore(idStore, start, end));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore, DateTime start,DateTime end, int pag, int element)
        {
            return Ok(_service.GetByStore(idStore,start,end,pag,element));
        }

        #endregion
       
        #region Count

        [HttpGet]

        [Route("Count/Store/{idStore}")]
        public IHttpActionResult Count(string idStore)
        {
            return Ok( _service.Count(idStore));
        }
        [HttpGet]

        [Route("Count/Store/{idStore},{start},{end}")]
        public IHttpActionResult Count(string idStore,DateTime start,DateTime end)
        {
            return Ok(_service.Count(idStore,start,end));
        }
        #endregion
    }
}
