using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using System.Collections.Generic;
using System.Web.Http;
using System.Net;

namespace Models.Controllers
{

    [RoutePrefix("Api/Autor")]
   // [Authorize]
    public class AutorController : ApiController 
    {

        readonly IAutorService _service ;

        public AutorController(IAutorService service)
        {
            _service = service;
        }

        #region Generics 
        [HttpGet]
        [Route("Count")]
        public IHttpActionResult Count()
        {
            return Content(HttpStatusCode.OK,_service.Count());
            
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
        public IHttpActionResult Post(List<AutorDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<AutorDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Content(HttpStatusCode.OK,_service.Delete(ids));
        }

        #endregion

        [HttpGet]
        [Route("Name")]
        public IHttpActionResult GetByName(string name)
        {
            return Content(HttpStatusCode.OK,_service.GetByName(name));
        }

        
        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByName(string text)
        {
            return Content(HttpStatusCode.OK,_service.SearchByName(text));
        }
        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByName(string text, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.SearchByName(text, pag, element));
        }
        [HttpGet]
        [Route("ExistName")]
        public IHttpActionResult ExistName(string name)
        {
            return Content(HttpStatusCode.OK,_service.ExistName(name));
        }



   


    }
}
