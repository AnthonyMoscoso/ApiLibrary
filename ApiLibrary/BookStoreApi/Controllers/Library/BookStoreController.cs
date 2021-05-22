using System.Collections.Generic;
using System.Web.Http;
using Models.Repositories.Concrect.Books;
using Models.Ado.Library;
using Ado.Library;

namespace Models.Controllers.Library.Books
{
    [RoutePrefix("Api/BookStore")]
    public class BookStoreController : ApiController
    {
       readonly IBookStoreRepository _repository = new BookStoreRepository();


        #region Generics 
        [HttpGet]
        [Route("Count")]
        public IHttpActionResult Count()
        {
            return Ok(_repository.Count());
        }
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
        public IHttpActionResult GetList(string ids)
        {
            return Ok(_repository.GetList(ids));
        }
        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int pag)
        {
            return Ok(_repository.Get(element, pag));
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

        #endregion
        [HttpGet]
        [Route("Stock")]
        public IHttpActionResult GetStock(string idBook,string idStore)
        {
            return Ok(_repository.GetStock(idBook,idStore));
        }


  
    }
}
