using System.Collections.Generic;
using System.Web.Http;
using Negocios.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.Books
{
    [RoutePrefix("Api/BookType")]
    public class BookTypeController : ApiController
    {
        readonly IBookTypeService _service;

        public BookTypeController(IBookTypeService service)
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
        public IHttpActionResult Post(List<BookTypeDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<BookTypeDto> list)
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
        [Route("Name")]
        public IHttpActionResult GetByName(string name)
        {
            return Ok(_service.GetByName(name));
        }
  

        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByName(string text)
        {
            return Ok(_service.SearchByName(text));
        }
        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByName(string text, int pag, int element)
        {
            return Ok(_service.SearchByName(text, pag, element));
        }
  
    }
}
