using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Books;
using BookStoreApi.Repositories.Concrect.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Books
{
    [RoutePrefix("Api/BookEditorial")]
    public class BookEditorialController : ApiController
    {
        readonly IBookEditorialRepository _repository = new BookEditorialRepository();

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
        [Route("PurchasePrice")]
        public IHttpActionResult GetPurchasePrice(string idBook,string idEditorial)
        {
            return Ok(_repository.GetPurchasePrice(idBook,idEditorial));
        }
        [HttpPost]
        public IHttpActionResult Post(List<BookEditorial> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<BookEditorial> list)
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
