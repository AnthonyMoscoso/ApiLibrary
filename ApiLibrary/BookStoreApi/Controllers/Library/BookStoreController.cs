using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Business.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.Books
{
    [RoutePrefix("Api/BookStore")]
    public class BookStoreController : ApiController
    {
       readonly IBookStoreService _service ;

        public BookStoreController(IBookStoreService service)
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
        public IHttpActionResult Post(List<BookStoreDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<BookStoreDto> list)
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
        [Route("Stock")]
        public IHttpActionResult GetStock(string idBook,string idStore)
        {
            return Content(HttpStatusCode.OK,_service.GetStock(idBook,idStore));
        }


  
    }
}
