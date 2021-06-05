using System.Collections.Generic;
using System.Web.Http;
using Negocios.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.Editorials
{
    [RoutePrefix("Api/Editorial")]
    public class EditorialController : ApiController
    {
        readonly IEditorialService _service;

        public EditorialController(IEditorialService service)
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
        public IHttpActionResult Get(int element, int page)
        {
            return Ok(_service.Get(element, page));
        }
        [HttpPost]
        public IHttpActionResult Post(List<EditorialDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<EditorialDto> list)
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
