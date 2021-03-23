using System.Collections.Generic;
using System.Web.Http;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.Books;
namespace BookStoreApi.Controllers.Library.Books
{
    [RoutePrefix("Api/BookStore")]
    public class BookStoreController : ApiController
    {
        public BookStoreRepository _repository = new BookStoreRepository();

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
        [Route("Stock")]
        public IHttpActionResult GetStock(string idBook,string idStore)
        {
            return Ok(_repository.GetStock(idBook,idStore));
        }
        [HttpPost]
        public IHttpActionResult Post(List<BookStore> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<BookStore> list)
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
