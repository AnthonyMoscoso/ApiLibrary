using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Books
{
    [RoutePrefix("Api/Book")]
    public class BookController : ApiController
    {
        public BookRepositorie _repository = new BookRepositorie();

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repository.Get());
        }
        [HttpPost]
        [Route("List")]
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
        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByName(string text)
        {
            return Ok(_repository.SearchByName(text));
        }
        [HttpGet]
        [Route("SearchByAutorName")]
        public IHttpActionResult SearchByAutorName(string text)
        {
            return Ok(_repository.SearchByAutorName(text));
        }
        [HttpGet]
        [Route("SearchByAutorName")]
        public IHttpActionResult SearchByAutorName(string text, int pag, int element)
        {
            return Ok(_repository.SearchByAutorName(text, pag,  element));
        }
        [HttpGet]
        [Route("Autor")]
        public IHttpActionResult GetByAutor(string idAutor)
        {
            return Ok(_repository.GetByAutor(idAutor));
        }
        [HttpGet]
        [Route("Autor")]
        public IHttpActionResult GetByAutor(string idAutor,int pag,int element)
        {
            return Ok(_repository.GetByAutor(idAutor,pag,element));
        }
        [HttpGet]
        [Route("Categorie")]
        public IHttpActionResult GetByCategorie(string idCategorie)
        {
            return Ok(_repository.GetByCategorie(idCategorie));
        }
        [HttpGet]
        [Route("Categorie")]
        public IHttpActionResult GetByCategorie(string idCategorie,int pag,int element)
        {
            return Ok(_repository.GetByCategorie(idCategorie,pag,element));
        }
        [HttpGet]
        [Route("Edition")]
        public IHttpActionResult GetByEdition(string idEdition)
        {
            return Ok(_repository.GetByEdition(idEdition));
        }
        [HttpGet]
        [Route("Edition")]
        public IHttpActionResult GetByEdition(string idEdition, int pag, int element)
        {
            return Ok(_repository.GetByEdition(idEdition, pag, element));
        }
        [HttpGet]
        [Route("Editorial")]
        public IHttpActionResult GetByEditorial(string idEditorial)
        {
            return Ok(_repository.GetByEditorial(idEditorial));
        }
        [HttpGet]
        [Route("Editorial")]
        public IHttpActionResult GetByEditorial(string idEditorial, int pag, int element)
        {
            return Ok(_repository.GetByEditorial(idEditorial, pag, element));
        }
        [HttpGet]
        [Route("Gender")]
        public IHttpActionResult GetByGender(List<string> idGender)
        {
            return Ok(_repository.GetByGender(idGender));
        }
        [HttpGet]
        [Route("Gender")]
        public IHttpActionResult GetByGender(List<string> idGender, int pag, int element)
        {
            return Ok(_repository.GetByGender(idGender, pag, element));
        }
        [HttpPost]
        public IHttpActionResult Post(List<Book> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Book> list)
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
