using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Negocios.BookStoreServices.Specifics;
using Negocios.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.Books
{
    [RoutePrefix("Api/Book")]
    public class BookController : ApiController
    {
        readonly IBookService _service ;

        public BookController(BookService service)
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
        public IHttpActionResult Post(List<BookDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<BookDto> list)
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
        public IHttpActionResult SearchByName(string text)
        {
            return Ok(_service.SearchByName(text));
        }
        [HttpGet]
        [Route("Name")]
        public IHttpActionResult SearchByName(string text,int pag,int element)
        {
            return Ok(_service.SearchByName(text,pag,element));
        }
        [HttpGet]
        [Route("Autor")]
        public IHttpActionResult SearchByAutorName(string text)
        {
            return Ok(_service.SearchByAutorName(text));
        }
        [HttpGet]
        [Route("Autor")]
        public IHttpActionResult SearchByAutorName(string text, int pag, int element)
        {
            return Ok(_service.SearchByAutorName(text, pag,  element));
        }
        [HttpGet]
        [Route("Autor")]
        public IHttpActionResult GetByAutor(string idAutor)
        {
            return Ok(_service.GetByAutor(idAutor));
        }
        [HttpGet]
        [Route("Autor")]
        public IHttpActionResult GetByAutor(string idAutor,int pag,int element)
        {
            return Ok(_service.GetByAutor(idAutor,pag,element));
        }
        [HttpGet]
        [Route("Category")]
        public IHttpActionResult GetByCategory(string idCategorie)
        {
            return Ok(_service.GetByCategory(idCategorie));
        }
        [HttpGet]
        [Route("Category")]
        public IHttpActionResult GetByCategory(string idCategorie,int pag,int element)
        {
            return Ok(_service.GetByCategory(idCategorie,pag,element));
        }
        [HttpGet]
        [Route("Edition")]
        public IHttpActionResult GetByEdition(string idEdition)
        {
            return Ok(_service.GetByEdition(idEdition));
        }
        [HttpGet]
        [Route("Edition")]
        public IHttpActionResult GetByEdition(string idEdition, int pag, int element)
        {
            return Ok(_service.GetByEdition(idEdition, pag, element));
        }
        [HttpGet]
        [Route("Editorial")]
        public IHttpActionResult GetByEditorial(string idEditorial)
        {
            return Ok(_service.GetByEditorial(idEditorial));
        }
        [HttpGet]
        [Route("Editorial")]
        public IHttpActionResult GetByEditorial(string idEditorial, int pag, int element)
        {
            return Ok(_service.GetByEditorial(idEditorial, pag, element));
        }
        [HttpGet]
        [Route("Gender")]
        public IHttpActionResult GetByGender(string genders)
        {
            List<string> ids = genders.Split(',').ToList();
            return Ok(_service.GetByGender(ids));
        }
        [HttpGet]
        [Route("Gender")]
        public IHttpActionResult GetByGender(string genders, int pag, int element)
        {
            List<string> ids = genders.Split(',').ToList();
            return Ok(_service.GetByGender(ids, pag, element));
        }
    

 

    }
}
