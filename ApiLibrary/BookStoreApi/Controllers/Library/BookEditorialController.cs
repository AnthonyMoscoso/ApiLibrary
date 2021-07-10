using System.Collections.Generic;
using System.Web.Http;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using System.Net;

namespace Models.Controllers.Library.Books
{
    [RoutePrefix("Api/BookEditorial")]
    [Authorize]
    public class BookEditorialController : ApiController
    {
        readonly IBookEditorialService _service ;

        public BookEditorialController(IBookEditorialService service)
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
        public IHttpActionResult Post(List<BookEditorialDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<BookEditorialDto> list)
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
        [Route("PurchasePrice")]
        public IHttpActionResult GetPurchasePrice(string idBook,string idEditorial)
        {
            return Content(HttpStatusCode.OK,_service.GetPurchasePrice(idBook,idEditorial));
        }
  
    }
}
