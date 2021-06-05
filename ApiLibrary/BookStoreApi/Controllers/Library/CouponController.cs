using System;
using System.Collections.Generic;
using System.Web.Http;
using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;

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
        public IHttpActionResult Get(int element, int page)
        {
            return Ok(_service.Get(element, page));
        }

        [HttpPost]
        public IHttpActionResult Post(List<CouponDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<CouponDto> list)
        {
            return Ok(_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_service.Delete(ids));
        }




        #endregion
        
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
        [Route("Sale")]
        public IHttpActionResult GetBySale(string idSale)
        {
            return Ok(_service.GetBySale(idSale));
        }
        [HttpGet]
        [Route("Sale")]
        public IHttpActionResult GetBySale(string idSale,int pag,int element)
        {
            return Ok(_service.GetBySale(idSale,pag,element));
        }
        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized()
        {
            return Ok(_service.GetFinalized());
        }
        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized(int pag,int element)
        {
            return Ok(_service.GetFinalized(pag,element));
        }
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
   
    }
}
