using System.Collections.Generic;
using System.Web.Http;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;

namespace Models.Controllers.Library.Books
{
    [RoutePrefix("Api/BookEditorial")]
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
            return Ok(_service.Count());
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_service.Get());
        }

        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return Ok(_service.Get(id));
        }

        [HttpGet]
        public IHttpActionResult GetList(string ids)
        {
            return Ok(_service.GetList(ids));
        }
        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int pag)
        {
            return Ok(_service.Get(element, pag));
        }
        [HttpPost]
        public IHttpActionResult Post(List<BookEditorialDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<BookEditorialDto> list)
        {
            return Ok(_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_service.Delete(ids));
        }

        #endregion

        [HttpGet]
        [Route("PurchasePrice")]
        public IHttpActionResult GetPurchasePrice(string idBook,string idEditorial)
        {
            return Ok(_service.GetPurchasePrice(idBook,idEditorial));
        }
  
    }
}
