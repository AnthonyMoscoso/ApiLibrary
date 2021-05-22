using Ado.Library;
using Models.Dtos;
using Models.Repositories.Concrect.Persons;
using System.Collections.Generic;
using System.Web.Http;

namespace Models.Controllers.Library.Persons
{
    [RoutePrefix("Api/Socie")]
    public class SocieController : ApiController
    {
        readonly ISocieRepository _repository = new SocieRepository();

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

        [HttpGet]
        public IHttpActionResult GetList(string ids)
        {
            return Ok(_repository.GetList(ids));
        }
        [HttpGet]
        public IHttpActionResult GetByDni(string dni)
        {
            return Ok(_repository.GetByDni(dni));
        }

        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int pag)
        {
            return Ok(_repository.Get(element, pag));
        }
        #endregion

        [HttpPost]
        public IHttpActionResult Post(List<SocieDto> list)
        {
           
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<SocieDto> list)
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
