using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Business.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.Sales
{
    [RoutePrefix("Api/Sale")]
    [Authorize]
    public class SaleController : ApiController
    {
        readonly ISaleService _service ;

        public SaleController(ISaleService service)
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
        #region Buyer
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer)
        {
            return Content(HttpStatusCode.OK,_service.GetByBuyer(idBuyer));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer,DateTime date)
        {
            return Content(HttpStatusCode.OK,_service.GetByBuyer(idBuyer,date));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer, DateTime start,DateTime end)
        {
            return Content(HttpStatusCode.OK,_service.GetByBuyer(idBuyer, start,end));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByBuyer(idBuyer,pag,element));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer,DateTime date, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByBuyer(idBuyer,date, pag, element));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer, DateTime start, DateTime end, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByBuyer(idBuyer, start, end, pag, element));
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

        #region PayMethod
        [HttpGet]
        [Route("PayMethod")]
        public IHttpActionResult GetByPayMethod(int payMethod)
        {
            return Content(HttpStatusCode.OK,_service.GetByPayMethod(payMethod));
        }

        [HttpGet]
        [Route("PayMethod")]
        public IHttpActionResult GetByPayMethod(int payMethod,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByPayMethod(payMethod,pag,element));
        }

        #endregion

        #region SaleStatus
        [HttpGet]
        [Route("SaleStatus")]
        public IHttpActionResult GetBySaleStatus(int SaleStatus)
        {
            return Content(HttpStatusCode.OK,_service.GetBySaleStatus(SaleStatus));
        }

        [HttpGet]
        [Route("SaleStatus")]
        public IHttpActionResult GetBySaleStatus(int SaleStatus, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetBySaleStatus(SaleStatus, pag, element));
        }
     
  
        #endregion

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
        public IHttpActionResult Post(List<SaleDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<SaleDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Content(HttpStatusCode.OK,_service.Delete(ids));
        }
    }
}
