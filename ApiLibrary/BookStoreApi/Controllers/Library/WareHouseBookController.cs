using Models.Repositories.Concrect.WareHouses;
using System.Collections.Generic;
using System.Web.Http;
using Models.Ado.Library;
using Ado.Library;

namespace Models.Controllers.Library
{
    [RoutePrefix("Api/WareHouseBook")]
    public class WareHouseBookController : ApiController
    {
        readonly IWareHouseBookRepository _repository = new WareHouseBookRepository();

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
