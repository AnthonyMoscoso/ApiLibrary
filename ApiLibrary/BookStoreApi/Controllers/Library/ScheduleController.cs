using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.Schedules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Schedules
{
    [RoutePrefix("Api/Schedule")]
    public class ScheduleController : ApiController
    {
        public ScheduleRepositorie _repository = new ScheduleRepositorie();

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
        #endregion

        #region Store
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore)
        {
            return Ok(_repository.GetByStore(idStore));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore, int year)
        {
            return Ok(_repository.GetByStore(idStore, year));
        }
        #endregion

        #region WareHouse
        [HttpGet]
        [Route("WareHouse")]
        public IHttpActionResult GetByWareHouse(string idWareHouse)
        {
            return Ok(_repository.GetByEmployee(idWareHouse));
        }
        [HttpGet]
        [Route("WareHouse")]
        public IHttpActionResult GetByWareHouse(string idWareHouse, int year)
        {
            return Ok(_repository.GetByEmployee(idWareHouse, year));
        }
        #endregion

        [HttpGet]
        [Route("List")]
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
