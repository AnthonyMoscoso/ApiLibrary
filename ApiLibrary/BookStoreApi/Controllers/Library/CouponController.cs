using System;
using System.Collections.Generic;
using System.Web.Http;
using Models.Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using System.Net;

namespace Models.Controllers.Library.Coupons
{
    [RoutePrefix("Api/Coupon")]
    public class CouponController : ApiController
    {
        readonly ICouponService _service;

        public CouponController(ICouponService service )
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
        public IHttpActionResult Get(int element, int page)
        {
            return Content(HttpStatusCode.OK,_service.Get(element, page));
        }

        [HttpPost]
        public IHttpActionResult Post(List<CouponDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<CouponDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Content(HttpStatusCode.OK,_service.Delete(ids));
        }




        #endregion
        
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
        [Route("Sale")]
        public IHttpActionResult GetBySale(string idSale)
        {
            return Content(HttpStatusCode.OK,_service.GetBySale(idSale));
        }
        [HttpGet]
        [Route("Sale")]
        public IHttpActionResult GetBySale(string idSale,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetBySale(idSale,pag,element));
        }
        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized()
        {
            return Content(HttpStatusCode.OK,_service.GetFinalized());
        }
        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized(int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetFinalized(pag,element));
        }
        [HttpGet]
        [Route("NotFinalized")]
        public IHttpActionResult GetNotFinalized()
        {
            return Content(HttpStatusCode.OK,_service.GetNotFinalized());
        }
        [HttpGet]
        [Route("NotFinalized")]
        public IHttpActionResult GetNotFinalized(int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetNotFinalized(pag, element));
        }
   
    }
}
