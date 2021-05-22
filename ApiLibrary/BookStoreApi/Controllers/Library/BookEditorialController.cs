using System.Collections.Generic;
using System.Web.Http;
using Ado.Library;
using Models.Ado.Library;
using Models.Repositories.Concrect.Books;

namespace Models.Controllers.Library.Books
{
    [RoutePrefix("Api/BookEditorial")]
    public class BookEditorialController : ApiController
    {
        readonly IBookEditorialRepository _repository = new BookEditorialRepository();

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

        #endregion

        [HttpGet]
        [Route("PurchasePrice")]
        public IHttpActionResult GetPurchasePrice(string idBook,string idEditorial)
        {
            return Ok(_repository.GetPurchasePrice(idBook,idEditorial));
        }
  
    }
}
