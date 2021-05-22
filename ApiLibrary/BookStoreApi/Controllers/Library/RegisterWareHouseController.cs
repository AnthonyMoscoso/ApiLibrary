using Ado.Library;
using Models.Models.Dtos;
using Models.Repositories.Abstract;
using Models.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Models.Controllers.Library
{
    public class RegisterWareHouseController : ApiController
    {
        readonly IRegisterWareHouseRepository _repository = new RegisterWareHouseRepository();

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
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_repository.Delete(ids));
        }

        #endregion

        #region By WareHouse
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
        public IHttpActionResult GetByWareHouse(string idWareHouse, DateTime date)
        {
            return Ok(_repository.GetByWareHouse(idWareHouse, date));
        }

        [HttpGet]
        public IHttpActionResult GetByWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            return Ok(_repository.GetByWareHouse(idWareHouse, date, pag, element));
        }

        [HttpGet]
        public IHttpActionResult GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd)
        {
            return Ok(_repository.GetByWareHouse(idWareHouse, dateStart, dateEnd));
        }

        [HttpGet]
        public IHttpActionResult GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            return Ok(_repository.GetByWareHouse(idWareHouse, dateStart, dateEnd, pag, element));
        }

        #endregion

    }
}
