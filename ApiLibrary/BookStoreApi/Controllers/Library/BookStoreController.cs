using System.Collections.Generic;
using System.Web.Http;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.Books;
namespace BookStoreApi.Controllers.Library.Books
{
    [RoutePrefix("Api/BookStore")]
    public class BookStoreController : ApiController
    {
        public BookStoreRepositorie _repository = new BookStoreRepositorie();

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repository.Get());
        }
        [HttpPost]
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
