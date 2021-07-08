using System;
using System.Net;
using System.Web.Http;
using Business.BookStoreServices.Abstracts;

namespace Models.Controllers.Library.Returns
{
    [RoutePrefix("Api/Return")]
    [Authorize]
    public class ReturnController : ApiController 
    {
        readonly IReturnSaleService _service ;

        public ReturnController(IReturnSaleService service)
        {
            _service = service;
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

        #region Date
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date)
        {
            return Content(HttpStatusCode.OK,_service.GetByDate(date));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start,DateTime end)
        {
            return Content(HttpStatusCode.OK,_service.GetByDate(start,end));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByDate(date,pag,element));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start,DateTime end, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByDate(start,end, pag, element));
        }
        #endregion

        #region Method
        [HttpGet]
        [Route("Method")]
        public IHttpActionResult GetByMethod(int method)
        {
            return Content(HttpStatusCode.OK,_service.GetByMethod(method));
        }
        [HttpGet]
        [Route("Method")]
        public IHttpActionResult GetByMethod(int method, string idStore)
        {
            return Content(HttpStatusCode.OK,_service.GetByMethod(method, idStore));
        }
        [HttpGet]
        [Route("Method")]
        public IHttpActionResult GetByMethod(int method,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByMethod(method,pag,element));
        }
        [HttpGet]
        [Route("Method")]
        public IHttpActionResult GetByMethod(int method,string idStore, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByMethod(method,idStore, pag, element));
        }
        #endregion

        #region Motive
        [HttpGet]
        [Route("Motive")]
        public IHttpActionResult GetByMotive(string motive)
        {
            return Content(HttpStatusCode.OK,_service.GetByMotive(motive));
        }
        [HttpGet]
        [Route("Motive")]
        public IHttpActionResult GetByMotive(string motive,string idStore)
        {
            return Content(HttpStatusCode.OK,_service.GetByMotive(motive,idStore));
        }
        [HttpGet]
        [Route("Motive")]
        public IHttpActionResult GetByMotive(string motive,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByMotive(motive,pag,element));
        }
        [HttpGet]
        [Route("Motive")]
        public IHttpActionResult GetByMotive(string motive,string idStore, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByMotive(motive,idStore, pag, element));
        }
        #endregion

        #region Sale 
        [HttpGet]
        [Route("Sale")]
        public IHttpActionResult GetBySale(string idSale)
        {
            return Content(HttpStatusCode.OK,_service.GetBySale(idSale));
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
        public IHttpActionResult GetByStore(string idStore,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByStore(idStore,pag,element));
        }
        #endregion

        [HttpGet]
        public IHttpActionResult GetList(string ids)
        {
            return Content(HttpStatusCode.OK,_service.GetList(ids));
        }

        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int page)
        {
            return Content(HttpStatusCode.OK,_service.Get(element, page));
        }
        /*[HttpPost]
        public IHttpActionResult Post(List<ReturnSaleDto> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<ReturnSaleDto> list)
        {
            return Ok(_repository.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_repository.Delete(ids));
        }*/


        #region WareHouse

        [HttpGet]
        [Route("WareHouse/{id}")]
        public IHttpActionResult GetByWareHouse(string id)
        {
            return Content(HttpStatusCode.OK,_service.GetByWareHouse(id));
        }

        [HttpGet]
        [Route("WareHouse")]
        public IHttpActionResult GetByWareHouse(string id, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByWareHouse(id, pag, element));
        }

        [HttpGet]
        [Route("WareHouse")]
        public IHttpActionResult GetByWareHouse(string id, DateTime start, DateTime end)
        {
            return Content(HttpStatusCode.OK,_service.GetByWareHouse(id, start, end));
        }

        [HttpGet]
        [Route("WareHouse")]
        public IHttpActionResult GetByWareHouse(string id, DateTime start, DateTime end, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByWareHouse(id, start, end, pag, element));
        }

        #endregion

    }
}
