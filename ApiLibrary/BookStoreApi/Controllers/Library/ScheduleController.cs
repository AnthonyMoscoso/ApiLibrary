using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Business.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.Schedules
{
    [RoutePrefix("Api/Schedule")]
    public class ScheduleController : ApiController
    {
        readonly IScheduleService _service ;

        public ScheduleController(IScheduleService service)
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
        #region Employee
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee)
        {
            return Content(HttpStatusCode.OK,_service.GetByEmployee(idEmployee));
        }
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee,int year)
        {
            return Content(HttpStatusCode.OK,_service.GetByEmployee(idEmployee,year));
        }
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee, int year ,int month)
        {
            return Content(HttpStatusCode.OK,_service.GetByEmployee(idEmployee,year,month));
        }
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee, int year ,int month ,int day)
        {
            return Content(HttpStatusCode.OK,_service.GetByEmployee(idEmployee, year,month,day));
        }
        #endregion

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
        public IHttpActionResult Post(List<ScheduleDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<ScheduleDto> list)
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
