using Models.Repositories.Concrect.Schedules;
using System.Collections.Generic;
using System.Web.Http;
using Models.Ado.Library;
using Ado.Library;

namespace Models.Controllers.Library.Schedules
{
    [RoutePrefix("Api/Schedule")]
    public class ScheduleController : ApiController
    {
        readonly IScheduleRepository _repository = new ScheduleRepository();

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repository.Get());
        }

        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return Ok(_repository.Get(id));
        }
        #region Employee
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee)
        {
            return Ok(_repository.GetByEmployee(idEmployee));
        }
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee,int year)
        {
            return Ok(_repository.GetByEmployee(idEmployee,year));
        }
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee, int year ,int month)
        {
            return Ok(_repository.GetByEmployee(idEmployee,year,month));
        }
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee, int year ,int month ,int day)
        {
            return Ok(_repository.GetByEmployee(idEmployee, year,month,day));
        }
        #endregion

        [HttpGet]
      
        public IHttpActionResult GetList(string ids)
        {
            return Ok(_repository.GetList(ids));
        }

        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int pag)
        {
            return Ok(_repository.Get(element, pag));
        }
        [HttpPost]
        public IHttpActionResult Post(List<Schedule> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Schedule> list)
        {
            return Ok(_repository.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_repository.Delete(ids));
        }
    }
}
