using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Models.Controllers.Library.Persons
{
    [Authorize]
    [RoutePrefix("Api/Employee")]
    public class EmployeeController : ApiController
    {
        readonly IEmployeeService _service ;
        public EmployeeController(IEmployeeService service)
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
        public IHttpActionResult Post(List<EmployeeDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<EmployeeDto> list)
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
        [Route("Boss")]
        public IHttpActionResult GetByBoss(string idBoss)
        {
            return Ok(_service.Get(idBoss));
        }
        [HttpGet]
        [Route("Boss")]
        public IHttpActionResult GetByBoss(string idBoss,int pag,int element)
        {
            return Ok(_service.GetByBoss(idBoss,pag,element));
        }
        [HttpGet]
        [Route("Dni")]
        public IHttpActionResult GetByDni(string dni)
        {
            return Ok(_service.GetByDni(dni));
        }
        [HttpGet]
        [Route("HireDate")]
        public IHttpActionResult GetByHireDate(DateTime date)
        {
            return Ok(_service.GetByHireDate(date));
        }
        [HttpGet]
        [Route("HireDate")]
        public IHttpActionResult GetByHireDate(DateTime date,int pag,int element)
        {
            return Ok(_service.GetByHireDate(date,pag,element));
        }
        [HttpGet]
        [Route("HireDate")]
        public IHttpActionResult GetByHireDateInStore(DateTime date,string idStore)
        {
            return Ok(_service.GetByStore(idStore,date));
        }
        [HttpGet]
        [Route("HireDate")]
        public IHttpActionResult GetByHireDateInStore(DateTime date,string idStore, int pag, int element)
        {
            return Ok(_service.GetByStore(idStore, date, pag, element));
        }
        [HttpGet]
        [Route("HireDate")]
        public IHttpActionResult GetByHireDateInWareHouse(DateTime date, string idStore)
        {
            return Ok(_service.GetByWareHouse(idStore, date));
        }
        [HttpGet]
        [Route("HireDate")]
        public IHttpActionResult GetByHireDateInWareHouse(DateTime date, string idWareHouse, int pag, int element)
        {
            return Ok(_service.GetByWareHouse(idWareHouse, date, pag, element));
        }
        [HttpGet]
        [Route("Occupation")]
        public IHttpActionResult GetByOccupation(string idOccupation)
        {
            return Ok(_service.GetByOccupation(idOccupation));
        }
        [HttpGet]
        [Route("Occupation")]
        public IHttpActionResult GetByOccupation(string idOccupation,int pag,int element)
        {
            return Ok(_service.GetByOccupation(idOccupation,pag,element));
        }
        [HttpGet]
        [Route("Occupation")]
        public IHttpActionResult GetByOccupationInStore(string idOccupation, string idStore)
        {
            return Ok(_service.GetByOccupationInStore(idOccupation, idStore));
        }
        [HttpGet]
        [Route("Occupation")]
        public IHttpActionResult GetByOccupationInStore(string idOccupation,string idStore, int pag, int element)
        {
            return Ok(_service.GetByOccupationInStore(idOccupation,idStore, pag, element));
        }
        [HttpGet]
        [Route("Occupation")]
        public IHttpActionResult GetByOccupationInWareHouse(string idOccupation, string idWareHouse)
        {
            return Ok(_service.GetByOccupationInStore(idOccupation, idWareHouse));
        }
        [HttpGet]
        [Route("Occupation")]
        public IHttpActionResult GetByOccupationInWareHouse(string idOccupation, string idWareHouse, int pag, int element)
        {
            return Ok(_service.GetByOccupationInStore(idOccupation, idWareHouse, pag, element));
        }
        [HttpGet]
        [Route("StartDate")]
        public IHttpActionResult GetByStartDate(DateTime date)
        {
            return Ok(_service.GetByStartDate(date));
        }
        [HttpGet]
        [Route("StartDate")]
        public IHttpActionResult GetByStartDate(DateTime date, int pag, int element)
        {
            return Ok(_service.GetByStartDate(date,pag,element));
        }
        [HttpGet]
        [Route("StartDate")]
        public IHttpActionResult GetByStartDateInStore(string idStore,DateTime date)
        {
            return Ok(_service.GetByStartDateInStore(idStore,date));
        }
        [HttpGet]
        [Route("StartDate")]
        public IHttpActionResult GetByStartDateInStore(string idStore,DateTime date, int pag, int element)
        {
            return Ok(_service.GetByStartDateInStore(idStore,date, pag, element));
        }
        [HttpGet]
        [Route("StartDate")]
        public IHttpActionResult GetByStartDateInWareHouse(string idWareHouse, DateTime date)
        {
            return Ok(_service.GetByStartDateInWareHouse(idWareHouse, date));
        }
        [HttpGet]
        [Route("StartDate")]
        public IHttpActionResult GetByStartDateInWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            return Ok(_service.GetByStartDateInWareHouse(idWareHouse, date, pag, element));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore)
        {
            return Ok(_service.GetByStore(idStore));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore,int pag,int element)
        {
            return Ok(_service.GetByStore(idStore,pag,element));
        }
        [HttpGet]
        [Route("WareHouse")]
        public IHttpActionResult GetByWareHouse(string idWareHouse)
        {
            return Ok(_service.GetByStore(idWareHouse));
        }
        [HttpGet]
        [Route("WareHouse")]
        public IHttpActionResult GetByWareHouse(string idWareHouse, int pag, int element)
        {
            return Ok(_service.GetByStore(idWareHouse, pag, element));
        }

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

        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByNameInStore(string idStore,string text)
        {
            return Ok(_service.SearchByStore(idStore,text));
        }
        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByNameInStore(string idStore,string text, int pag, int element)
        {
            return Ok(_service.SearchByStore(idStore, text, pag, element));
        }
        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByNameInWareHouse(string idWareHouse, string text)
        {
            return Ok(_service.SearchByWareHouse(idWareHouse, text));
        }
        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByNameInWareHouse(string idWareHouse, string text, int pag, int element)
        {
            return Ok(_service.SearchByWareHouse(idWareHouse, text, pag, element));
        }

        [HttpPost]
        [Route("Hire")]
        public IHttpActionResult HireEmployee(EmployeeWorkPlace hire)
        {
            return Ok(_service.Hire(hire)); ;
        }
        [HttpPost]
        [Route("Fired")]
        public IHttpActionResult FiredEmployee(EmployeeWorkPlace employeeWorkPlace)
        {
            return Ok(_service.Fired(employeeWorkPlace)); ;
        }

   
    }
}
