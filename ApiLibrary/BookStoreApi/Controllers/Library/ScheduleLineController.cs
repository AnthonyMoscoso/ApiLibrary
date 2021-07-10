using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Business.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library
{
    [Authorize]
    [RoutePrefix("Api/ScheduleLine")]
    public class ScheduleLineController : ApiController
    {
        readonly IScheduleLineService _service ;

        public ScheduleLineController(IScheduleLineService service)
        {
            _service = service;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Content(HttpStatusCode.OK,_service.Get());
        }

        [HttpGet]
        public IHttpActionResult Get(string idSchedule)
        {
            return Content(HttpStatusCode.OK,_service.GetBySchedule(idSchedule));
        }
        [HttpGet]
        public IHttpActionResult Get(string idSchedule,int month)
        {
            return Content(HttpStatusCode.OK,_service.GetBySchedule(idSchedule,month));
        }
        [HttpGet]
        public IHttpActionResult Get(string idSchedule, int month,int day)
        {
            return Content(HttpStatusCode.OK,_service.GetBySchedule(idSchedule, month,day));
        }
        [HttpPost]
        public IHttpActionResult Post(List<ScheduleLineDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<ScheduleLineDto> list)
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
