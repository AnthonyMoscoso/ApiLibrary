using System.Collections.Generic;
using System.Web.Http;
using Business.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library
{
    [RoutePrefix("Api/WareHouseBook")]
    public class WareHouseBookController : ApiController
    {
        readonly IWareHouseBookService _service ;


        public WareHouseBookController(IWareHouseBookService service)
        {
            _service = service;
        }


        #region Get
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
        #endregion
        [HttpGet]
        [Route("Stock")]
        public IHttpActionResult GetStock(string idBook, string idWareHouse)
        {
            return Ok(_service.GetStock(idBook, idWareHouse));
        }
        [HttpPost]
        public IHttpActionResult Post(List<WareHouseBookDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<WareHouseBookDto> list)
        {
            return Ok(_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_service.Delete(ids));
        }
    }
}
