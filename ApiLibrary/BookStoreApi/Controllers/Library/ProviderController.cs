using System.Collections.Generic;
using System.Web.Http;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;

namespace Models.Controllers.Library.Provide
{
    [RoutePrefix("Api/Provider")]
    public class ProviderController : ApiController
    {
        readonly IProviderService _service ;


        public ProviderController(IProviderService service)
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
        public IHttpActionResult Post(List<ProviderDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<ProviderDto> list)
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
