using Ado.Library;
using Models.Models.Dtos;
using Models.Repositories.Abstract;
using Ado.Library.Specifics;
using Negocios.BookStoreServices.Abstracts;
using System.Collections.Generic;
using System.Web.Http;

namespace Models.Controllers.Library
{
    public class ReservationOnlineController : ApiController
    {
        readonly IReservationOnlineService _service ;

        public ReservationOnlineController(IReservationOnlineService service)
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
        public IHttpActionResult Post(List<ReservationOnlineDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<ReservationOnlineDto> list)
        {
            return Ok(_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_service.Delete(ids));
        }

        #endregion
    }
}
