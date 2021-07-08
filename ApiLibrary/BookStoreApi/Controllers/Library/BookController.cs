using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Business.BookStoreServices.Specifics;
using Business.BookStoreServices.Abstracts;
using Models.Dtos;
using System.Net;

namespace Models.Controllers.Library.Books
{
    [RoutePrefix("Api/Book")]
    public class BookController : ApiController
    {
        readonly IBookService _service ;

        public BookController(IBookService service)
        {
            _service = service;
        }

        #region Generics 
        [HttpGet]
        [Route("Count")]
        public IHttpActionResult Count()
        {
            return Content( System.Net.HttpStatusCode.OK,_service.Count());
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
        public IHttpActionResult Post(IEnumerable<BookDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(IEnumerable<BookDto> list)
        {
            return Content(System.Net.HttpStatusCode.BadRequest,_service.Update(list)); ;
        }

        [HttpDelete]
        public IHttpActionResult Delete(IEnumerable<string> ids)
        {
            return Content(HttpStatusCode.OK,_service.Delete(ids));
        }

        #endregion

        [HttpGet]
        [Route("Name")]
        public IHttpActionResult SearchByName(string text)
        {
            return Content(HttpStatusCode.OK,_service.SearchByName(text));
        }
        [HttpGet]
        [Route("Name")]
        public IHttpActionResult SearchByName(string text,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.SearchByName(text,pag,element));
        }
        [HttpGet]
        [Route("Autor")]
        public IHttpActionResult SearchByAutorName(string text)
        {
            return Content(HttpStatusCode.OK,_service.SearchByAutorName(text));
        }
        [HttpGet]
        [Route("Autor")]
        public IHttpActionResult SearchByAutorName(string text, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.SearchByAutorName(text, pag,  element));
        }
        [HttpGet]
        [Route("Autor")]
        public IHttpActionResult GetByAutor(string idAutor)
        {
            return Content(HttpStatusCode.OK,_service.GetByAutor(idAutor));
        }
        [HttpGet]
        [Route("Autor")]
        public IHttpActionResult GetByAutor(string idAutor,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByAutor(idAutor,pag,element));
        }
        [HttpGet]
        [Route("Category")]
        public IHttpActionResult GetByCategory(string idCategorie)
        {
            return Content(HttpStatusCode.OK,_service.GetByCategory(idCategorie));
        }
        [HttpGet]
        [Route("Category")]
        public IHttpActionResult GetByCategory(string idCategorie,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByCategory(idCategorie,pag,element));
        }
        [HttpGet]
        [Route("Edition")]
        public IHttpActionResult GetByEdition(string idEdition)
        {
            return Content(HttpStatusCode.OK,_service.GetByEdition(idEdition));
        }
        [HttpGet]
        [Route("Edition")]
        public IHttpActionResult GetByEdition(string idEdition, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByEdition(idEdition, pag, element));
        }
        [HttpGet]
        [Route("Editorial")]
        public IHttpActionResult GetByEditorial(string idEditorial)
        {
            return Content(HttpStatusCode.OK,_service.GetByEditorial(idEditorial));
        }
        [HttpGet]
        [Route("Editorial")]
        public IHttpActionResult GetByEditorial(string idEditorial, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByEditorial(idEditorial, pag, element));
        }
        [HttpGet]
        [Route("Gender")]
        public IHttpActionResult GetByGender(string genders)
        {
            List<string> ids = genders.Split(',').ToList();
            return Content(HttpStatusCode.OK,_service.GetByGender(ids));
        }
        [HttpGet]
        [Route("Gender")]
        public IHttpActionResult GetByGender(string genders, int pag, int element)
        {
            List<string> ids = genders.Split(',').ToList();
            return Content(HttpStatusCode.OK,_service.GetByGender(ids, pag, element));
        }
    

 

    }
}
