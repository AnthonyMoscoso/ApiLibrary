using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Books;
using BookStoreApi.Repositories.Concrect.Books;
using System.Collections.Generic;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Books
{
    [RoutePrefix("Api/BookType")]
    public class BookTypeController : ApiController
    {
        readonly IBookTypeRepository _repository = new BookTypeRepository();
 

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
        [Route("List")]
        public IHttpActionResult GetList(string ids)
        {
            return Ok(_repository.GetList(ids));
        }

        [HttpGet]
        [Route("Name")]
        public IHttpActionResult GetByName(string name)
        {
            return Ok(_repository.GetByName(name));
        }
        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int pag)
        {
            return Ok(_repository.Get(element, pag));
        }

        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByName(string text)
        {
            return Ok(_repository.SearchByName(text));
        }
        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByName(string text, int pag, int element)
        {
            return Ok(_repository.SearchByName(text, pag, element));
        }
        [HttpPost]
        public IHttpActionResult Post(List<BookType> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<BookType> list)
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
