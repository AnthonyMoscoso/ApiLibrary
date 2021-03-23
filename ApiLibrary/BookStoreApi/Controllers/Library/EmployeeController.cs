using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Persons
{
    [Authorize]
    [RoutePrefix("Api/Employee")]
    public class EmployeeController : ApiController
    {
        public EmployeeRepositorie _repository = new EmployeeRepositorie();

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
        [Route("Boss")]
        public IHttpActionResult GetByBoss(string idBoss)
        {
            return Ok(_repository.Get(idBoss));
        }
        [HttpGet]
        [Route("Boss")]
        public IHttpActionResult GetByBoss(string idBoss,int pag,int element)
        {
            return Ok(_repository.GetByBoss(idBoss,pag,element));
        }
        [HttpGet]
        [Route("Dni")]
        public IHttpActionResult GetByDni(string dni)
        {
            return Ok(_repository.GetByDni(dni));
        }
        [HttpGet]
        [Route("HireDate")]
        public IHttpActionResult GetByHireDate(DateTime date)
        {
            return Ok(_repository.GetByHireDate(date));
        }
        [HttpGet]
        [Route("HireDate")]
        public IHttpActionResult GetByHireDate(DateTime date,int pag,int element)
        {
            return Ok(_repository.GetByHireDate(date,pag,element));
        }
        [HttpGet]
        [Route("HireDate")]
        public IHttpActionResult GetByHireDateInStore(DateTime date,string idStore)
        {
            return Ok(_repository.GetByHireDateInStore(idStore,date));
        }
        [HttpGet]
        [Route("HireDate")]
        public IHttpActionResult GetByHireDateInStore(DateTime date,string idStore, int pag, int element)
        {
            return Ok(_repository.GetByHireDateInStore(idStore, date, pag, element));
        }
        [HttpGet]
        [Route("HireDate")]
        public IHttpActionResult GetByHireDateInWareHouse(DateTime date, string idStore)
        {
            return Ok(_repository.GetByHireDateInWareHouse(idStore, date));
        }
        [HttpGet]
        [Route("HireDate")]
        public IHttpActionResult GetByHireDateInWareHouse(DateTime date, string idWareHouse, int pag, int element)
        {
            return Ok(_repository.GetByHireDateInWareHouse(idWareHouse, date, pag, element));
        }
        [HttpGet]
        [Route("Occupation")]
        public IHttpActionResult GetByOccupation(string idOccupation)
        {
            return Ok(_repository.GetByOccupation(idOccupation));
        }
        [HttpGet]
        [Route("Occupation")]
        public IHttpActionResult GetByOccupation(string idOccupation,int pag,int element)
        {
            return Ok(_repository.GetByOccupation(idOccupation,pag,element));
        }
        [HttpGet]
        [Route("Occupation")]
        public IHttpActionResult GetByOccupationInStore(string idOccupation, string idStore)
        {
            return Ok(_repository.GetByOccupationInStore(idOccupation, idStore));
        }
        [HttpGet]
        [Route("Occupation")]
        public IHttpActionResult GetByOccupationInStore(string idOccupation,string idStore, int pag, int element)
        {
            return Ok(_repository.GetByOccupationInStore(idOccupation,idStore, pag, element));
        }
        [HttpGet]
        [Route("Occupation")]
        public IHttpActionResult GetByOccupationInWareHouse(string idOccupation, string idWareHouse)
        {
            return Ok(_repository.GetByOccupationInStore(idOccupation, idWareHouse));
        }
        [HttpGet]
        [Route("Occupation")]
        public IHttpActionResult GetByOccupationInWareHouse(string idOccupation, string idWareHouse, int pag, int element)
        {
            return Ok(_repository.GetByOccupationInStore(idOccupation, idWareHouse, pag, element));
        }
        [HttpGet]
        [Route("StartDate")]
        public IHttpActionResult GetByStartDate(DateTime date)
        {
            return Ok(_repository.GetByStartDate(date));
        }
        [HttpGet]
        [Route("StartDate")]
        public IHttpActionResult GetByStartDate(DateTime date, int pag, int element)
        {
            return Ok(_repository.GetByStartDate(date,pag,element));
        }
        [HttpGet]
        [Route("StartDate")]
        public IHttpActionResult GetByStartDateInStore(string idStore,DateTime date)
        {
            return Ok(_repository.GetByStartDateInStore(idStore,date));
        }
        [HttpGet]
        [Route("StartDate")]
        public IHttpActionResult GetByStartDateInStore(string idStore,DateTime date, int pag, int element)
        {
            return Ok(_repository.GetByStartDateInStore(idStore,date, pag, element));
        }
        [HttpGet]
        [Route("StartDate")]
        public IHttpActionResult GetByStartDateInWareHouse(string idWareHouse, DateTime date)
        {
            return Ok(_repository.GetByStartDateInWareHouse(idWareHouse, date));
        }
        [HttpGet]
        [Route("StartDate")]
        public IHttpActionResult GetByStartDateInWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            return Ok(_repository.GetByStartDateInWareHouse(idWareHouse, date, pag, element));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore)
        {
            return Ok(_repository.GetByStore(idStore));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore,int pag,int element)
        {
            return Ok(_repository.GetByStore(idStore,pag,element));
        }
        [HttpGet]
        [Route("WareHouse")]
        public IHttpActionResult GetByWareHouse(string idWareHouse)
        {
            return Ok(_repository.GetByStore(idWareHouse));
        }
        [HttpGet]
        [Route("WareHouse")]
        public IHttpActionResult GetByWareHouse(string idWareHouse, int pag, int element)
        {
            return Ok(_repository.GetByStore(idWareHouse, pag, element));
        }

        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByName(string text)
        {
            return Ok(_repository.SearchByName(text));
        }
        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByName(string text, int pag, int element)
        {
            return Ok(_repository.SearchByName(text, pag, element));
        }

        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByNameInStore(string idStore,string text)
        {
            return Ok(_repository.SearchByNameInStore(idStore,text));
        }
        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByNameInStore(string idStore,string text, int pag, int element)
        {
            return Ok(_repository.SearchByNameInStore(idStore, text, pag, element));
        }
        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByNameInWareHouse(string idWareHouse, string text)
        {
            return Ok(_repository.SearchByNameInWareHouse(idWareHouse, text));
        }
        [HttpGet]
        [Route("SearchByName")]
        public IHttpActionResult SearchByNameInWareHouse(string idWareHouse, string text, int pag, int element)
        {
            return Ok(_repository.SearchByNameInWareHouse(idWareHouse, text, pag, element));
        }

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
        public IHttpActionResult Post(List<Employee> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Employee> list)
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
