using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.Coupons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Coupons
{
    [RoutePrefix("Api/Coupon")]
    public class CouponController : ApiController
    {
        public CouponRepositorie _repository = new CouponRepositorie();

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
        [Route("Sale")]
        public IHttpActionResult GetBySale(string idSale)
        {
            return Ok(_repository.GetBySale(idSale));
        }
        [HttpGet]
        [Route("Sale")]
        public IHttpActionResult GetBySale(string idSale,int pag,int element)
        {
            return Ok(_repository.GetBySale(idSale,pag,element));
        }
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
        [Route("Pag")]
        public IHttpActionResult Get(int element, int page)
        {
            return Ok(_repository.Get(element, page));
        }

        [HttpPost]
        public IHttpActionResult Post(List<Coupon> list)
        {
            return Ok(_repository.Insert(list));
        }
        [HttpPost]
        [Route("List")]
        public IHttpActionResult Get(List<string> ids)
        {
            return Ok(_repository.Get(ids));
        }
        [HttpPut]
        public IHttpActionResult Put(List<Coupon> list)
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
