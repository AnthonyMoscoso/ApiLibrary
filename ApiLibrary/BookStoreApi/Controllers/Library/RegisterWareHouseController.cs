using BookStoreApi.Models.Dtos;
using BookStoreApi.Repositories.Abstract;
using BookStoreApi.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library
{
    public class RegisterWareHouseController : ApiController
    {
        readonly IRegisterWareHouseRepository _repository = new RegisterWareHouseRepository();

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repository.Get());
        }

        [HttpGet]
        public IHttpActionResult GetByWareHouse(string idWareHouse)
        {
            return Ok(_repository.GetByWareHouse(idWareHouse));
        }
        [HttpGet]
        public IHttpActionResult GetByWareHouse(string idWareHouse, int pag, int element)
        {
            return Ok(_repository.GetByWareHouse(idWareHouse, pag, element));
        }
        [HttpGet]
        public IHttpActionResult GetByWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            return Ok(_repository.GetByWareHouse(idWareHouse, date, pag, element));
        }
        [HttpGet]
        public IHttpActionResult GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            return Ok(_repository.GetByWareHouse(idWareHouse, dateStart, dateEnd, pag, element));
        }

        [HttpPost]
        public IHttpActionResult Post(List<RegisterWareHouseDto> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<RegisterWareHouseDto> list)
        {
            return Ok(_repository.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string>ids)
        {
            return Ok(_repository.Delete(ids));
        }
    }
}
