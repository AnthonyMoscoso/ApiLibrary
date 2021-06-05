using System.Collections.Generic;
using System.Web.Http;
using Negocios.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.Taxe
{
    [RoutePrefix("Api/Taxes")]
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
        [HttpGet]
        [Route("Type")]
        public IHttpActionResult GetByType(int type)
        {
            return Ok(_service.GetByType(type));
        }
        [HttpGet]
        [Route("Type")]
        public IHttpActionResult GetByType(int type, int pag, int element)
        {
            return Ok(_service.GetByType(type, pag, element));
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
        [HttpPost]
        public IHttpActionResult Post(List<TaxesDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<TaxesDto> list)
        {
            return Ok(_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_service.Delete(ids));
        }
    }
}
