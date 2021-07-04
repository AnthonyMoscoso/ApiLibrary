using System.Collections.Generic;
using System.Web.Http;
using Business.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library
{
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
            return Ok(_service.Get());
        }

        [HttpGet]
        public IHttpActionResult Get(string idSchedule)
        {
            return Ok(_service.GetBySchedule(idSchedule));
        }
        [HttpGet]
        public IHttpActionResult Get(string idSchedule,int month)
        {
            return Ok(_service.GetBySchedule(idSchedule,month));
        }
        [HttpGet]
        public IHttpActionResult Get(string idSchedule, int month,int day)
        {
            return Ok(_service.GetBySchedule(idSchedule, month,day));
        }
        [HttpPost]
        public IHttpActionResult Post(List<ScheduleLineDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<ScheduleLineDto> list)
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
