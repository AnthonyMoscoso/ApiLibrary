using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.PayRolls;
using BookStoreApi.Repositories.Concrect.PayRolls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.PayRolls
{
    [RoutePrefix("Api/PayRoll")]
    public class PayRollController : ApiController
    {
        readonly IPayRollRepositorie _repository = new PayRollRepositorie();

        #region Generics 
        [HttpGet]
        [Route("Count")]
        public IHttpActionResult Count()
        {
            return Ok(_repository.Count());
        }
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
        public IHttpActionResult Post(List<PayRoll> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<PayRoll> list)
        {
            return Ok(_repository.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_repository.Delete(ids));
        }

        #endregion

        #region Date
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(int year)
        {
            return Ok(_repository.GetByDate(year));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(int year,int pag,int element)
        {
            return Ok(_repository.GetByDate(year,pag ,element));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(int year,int month)
        {
            return Ok(_repository.GetByDate(year,month));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(int year, int month, int pag, int element)
        {
            return Ok(_repository.GetByDate(year, month,pag,element));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date)
        {
            return Ok(_repository.GetByDate(date));
        }
        #endregion

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
        public IHttpActionResult GetByEmployee(string idEmployee, int year,int pag,int element)
        {
            return Ok(_repository.GetByEmployee(idEmployee, year,pag,element));
        }
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee, int year,int month)
        {
            return Ok(_repository.GetByEmployee(idEmployee, year,month));
        }
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee, int year, int month, int pag, int element)
        {
            return Ok(_repository.GetByEmployee(idEmployee, year, month,pag,element));
        }

        #endregion



    }
}
