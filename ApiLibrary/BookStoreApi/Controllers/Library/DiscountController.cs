using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Business.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.Discounts
{
    [RoutePrefix("Api/Discount")]
    [Authorize]
    public class DiscountController : ApiController
    {
        readonly IDiscountService _service ;

        public DiscountController(IDiscountService service)
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
        public IHttpActionResult Post(List<DiscountDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<DiscountDto> list)
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
        [Route("Book")]
        public IHttpActionResult GetByBook(string idBook)
        {
            return Content(HttpStatusCode.OK,_service.GetByBook(idBook));
        }
        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized()
        {
            return Content(HttpStatusCode.OK,_service.GetFinnalized());
        }
        [HttpGet]
        [Route("Finalized")]
        public IHttpActionResult GetFinalized(int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetFinnalized(pag,element));
        }
        [HttpGet]
        [Route("NotFinalized")]
        public IHttpActionResult GetNotFinalized()
        {
            return Content(HttpStatusCode.OK,_service.GetNotFinnalized());
        }
        [HttpGet]
        [Route("NotFinalized")]
        public IHttpActionResult GetNotFinalized(int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetNotFinnalized(pag, element));
        }
       
       
    }
}
