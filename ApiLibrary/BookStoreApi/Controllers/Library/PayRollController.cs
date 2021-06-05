using System;
using System.Collections.Generic;
using System.Web.Http;
using Negocios.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.PayRolls
{
    [RoutePrefix("Api/PayRoll")]
    public class PayRollController : ApiController
    {
        readonly IPayRollService _service;

        public PayRollController(IPayRollService service)
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
        public IHttpActionResult Post(List<PayRollDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<PayRollDto> list)
        {
            return Ok(_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_service.Delete(ids));
        }

        #endregion

        #region Date
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(int year)
        {
            return Ok(_service.GetByDate(year));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(int year,int pag,int element)
        {
            return Ok(_service.GetByDate(year,pag ,element));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(int year,int month)
        {
            return Ok(_service.GetByDate(year,month));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(int year, int month, int pag, int element)
        {
            return Ok(_service.GetByDate(year, month,pag,element));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date)
        {
            return Ok(_service.GetByDate(date));
        }
        #endregion

        #region Employee
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee)
        {
            return Ok(_service.GetByEmployee(idEmployee));
        }
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee,int year)
        {
            return Ok(_service.GetByEmployee(idEmployee,year));
        }
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee, int year,int pag,int element)
        {
            return Ok(_service.GetByEmployee(idEmployee, year,pag,element));
        }
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee, int year,int month)
        {
            return Ok(_service.GetByEmployee(idEmployee, year,month));
        }
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee, int year, int month, int pag, int element)
        {
            return Ok(_service.GetByEmployee(idEmployee, year, month,pag,element));
        }

        #endregion



    }
}
