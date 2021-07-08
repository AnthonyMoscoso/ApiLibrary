using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using System.Collections.Generic;
using System.Web.Http;
using System.Net;

namespace Models.Controllers.Library.Persons
{
    [RoutePrefix("Api/Socie")]
    public class SocieController : ApiController
    {
        readonly ISocieService _service ;

        public SocieController(ISocieService service)
        {
            _service = service;
        }

        #region Get
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
        public IHttpActionResult GetByDni(string dni)
        {
            return Content(HttpStatusCode.OK,_service.GetByDni(dni));
        }

        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int pag)
        {
            return Content(HttpStatusCode.OK,_service.Get(element, pag));
        }
        #endregion

        [HttpPost]
        public IHttpActionResult Post(List<SocieDto> list)
        {
           
            return Content(HttpStatusCode.OK,_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<SocieDto> list)
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
