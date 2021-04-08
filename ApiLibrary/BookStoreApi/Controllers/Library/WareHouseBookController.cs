using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.WareHouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library
{
    [RoutePrefix("Api/WareHouseBook")]
    public class WareHouseBookController : ApiController
    {
        readonly WareHouseBookRepository _repository;
        public WareHouseBookController()
        {
            _repository = new WareHouseBookRepository();
        }
        #region Get
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
        #endregion
        [HttpGet]
        [Route("Stock")]
        public IHttpActionResult GetStock(string idBook, string idWareHouse)
        {
            return Ok(_repository.GetStock(idBook, idWareHouse));
        }
        [HttpPost]
        public IHttpActionResult Post(List<WareHouseBook> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<WareHouseBook> list)
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
