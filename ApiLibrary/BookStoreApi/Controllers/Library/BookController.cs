using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract;
using BookStoreApi.Repositories.Concrect.Books;
using BookStoreApi.Repositories.Concrect.WareHouses;
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
        readonly IBookRepository _repository = new BookRepository();


        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repository.Get());
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
        [HttpGet]
        [Route("Name")]
        public IHttpActionResult SearchByName(string text)
        {
            return Ok(_repository.SearchByName(text));
        }
        [HttpGet]
        [Route("Name")]
        public IHttpActionResult SearchByName(string text,int pag,int element)
        {
            return Ok(_repository.SearchByName(text,pag,element));
        }
        [HttpGet]
        [Route("Autor")]
        public IHttpActionResult SearchByAutorName(string text)
        {
            return Ok(_repository.SearchByAutorName(text));
        }
        [HttpGet]
        [Route("Autor")]
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
        [Route("Category")]
        public IHttpActionResult GetByCategory(string idCategorie)
        {
            return Ok(_repository.GetByCategory(idCategorie));
        }
        [HttpGet]
        [Route("Category")]
        public IHttpActionResult GetByCategory(string idCategorie,int pag,int element)
        {
            return Ok(_repository.GetByCategory(idCategorie,pag,element));
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
        public IHttpActionResult GetByGender(string genders)
        {
            List<string> ids = genders.Split(',').ToList();
            return Ok(_repository.GetByGender(ids));
        }
        [HttpGet]
        [Route("Gender")]
        public IHttpActionResult GetByGender(string genders, int pag, int element)
        {
            List<string> ids = genders.Split(',').ToList();
            return Ok(_repository.GetByGender(ids, pag, element));
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
