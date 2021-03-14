using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Discounts
{
    [RoutePrefix("Api/Discount")]
    public class DiscountController : ApiController
    {
        public DiscountRepositorie _repository = new DiscountRepositorie();

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
        [Route("Book")]
        public IHttpActionResult GetByBook(string idBook)
        {
            return Ok(_repository.GetByBook(idBook));
        }
        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized()
        {
            return Ok(_repository.GetFinnalized());
        }
        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized(int pag,int element)
        {
            return Ok(_repository.GetFinnalized(pag,element));
        }
        [HttpGet]
        [Route("NotFinalized")]
        public IHttpActionResult GetNotFinalized()
        {
            return Ok(_repository.GetNotFinnalized());
        }
        [HttpGet]
        [Route("NotFinalized")]
        public IHttpActionResult GetNotFinalized(int pag, int element)
        {
            return Ok(_repository.GetNotFinnalized(pag, element));
        }
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
        public IHttpActionResult Post(List<Discount> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Discount> list)
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
