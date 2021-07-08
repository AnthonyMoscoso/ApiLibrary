using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Business.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.Receptions
{
    [RoutePrefix("Api/Reception")]
    public class ReceptionController : ApiController
    {
        readonly IReceptionService  _service;

        public ReceptionController(IReceptionService service )
        {
            _service = service;
        }

        #region Generics 
        [HttpGet]
        [Route("Count")]
        public IHttpActionResult Count()
        {
            return Content(HttpStatusCode.OK,_service.Count());
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Content(HttpStatusCode.OK,_service.Get());
        }

        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return Content(HttpStatusCode.OK,_service.Get(id));
        }

        [HttpGet]
        public IHttpActionResult GetList(string ids)
        {
            return Content(HttpStatusCode.OK,_service.GetList(ids));
        }

        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int pag)
        {
            return Content(HttpStatusCode.OK,_service.Get(element, pag));
        }

        [HttpPost]
        public IHttpActionResult Post(List<ReceptionDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<ReceptionDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Content(HttpStatusCode.OK,_service.Delete(ids));
        }

        #endregion

        #region Date
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date)
        {
            return Content(HttpStatusCode.OK,_service.GetByDate(date));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByDate(date,pag,element));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start,DateTime end)
        {
            return Content(HttpStatusCode.OK,_service.GetByDate(start,end));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByDate(start, end, pag, element));
        }

        #endregion

        #region Store
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore)
        {
            return Content(HttpStatusCode.OK,_service.GetByStore(idStore));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByStore(idStore, pag, element));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore,DateTime date)
        {
            return Content(HttpStatusCode.OK,_service.GetByStore(idStore,date));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore,DateTime date, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByStore(idStore,date, pag, element));
        }

        #endregion

    }
}
