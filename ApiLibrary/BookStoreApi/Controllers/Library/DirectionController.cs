using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Directions;
using BookStoreApi.Repositories.Concrect.Directions;
using System.Collections.Generic;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Directions
{
    [RoutePrefix("Api/Direction")]
    public class DirectionController : ApiController
    {
        readonly IDirectionRepository _repository = new DirectionRepository();

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
        public IHttpActionResult Get(int element, int page)
        {
            return Ok(_repository.Get(element, page));
        }

        [HttpPost]
        public IHttpActionResult Post(List<Direction> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Direction> list)
        {
            return Ok(_repository.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_repository.Delete(ids));
        }




        #endregion
    }
}
