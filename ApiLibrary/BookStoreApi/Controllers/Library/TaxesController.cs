using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Business.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.Taxe
{
    [RoutePrefix("Api/Taxes")]
    [Authorize]
    public class TaxesController : ApiController
    {
        readonly ITaxesService _service ;

        public TaxesController(ITaxesService service)
        {
            _service = service;
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
        [HttpGet]
        [Route("Type")]
        public IHttpActionResult GetByType(int type)
        {
            return Content(HttpStatusCode.OK,_service.GetByType(type));
        }
        [HttpGet]
        [Route("Type")]
        public IHttpActionResult GetByType(int type, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByType(type, pag, element));
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
        [HttpPost]
        public IHttpActionResult Post(List<TaxesDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<TaxesDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Content(HttpStatusCode.OK,_service.Delete(ids));
        }
    }
}
