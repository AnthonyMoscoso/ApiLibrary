
using Models.Repositories.Concrect.Taxe;
using System.Collections.Generic;
using Models.Ado.Library;
using System.Web.Http;
using Ado.Library;

namespace Models.Controllers.Library.Taxe
{
    [RoutePrefix("Api/Taxes")]
    public class TaxesController : ApiController
    {
        readonly ITaxesRepository _repository = new TaxesRepository();

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
        [HttpGet]
        [Route("Type")]
        public IHttpActionResult GetByType(int type)
        {
            return Ok(_repository.GetByType(type));
        }
        [HttpGet]
        [Route("Type")]
        public IHttpActionResult GetByType(int type, int pag, int element)
        {
            return Ok(_repository.GetByType(type, pag, element));
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
        [HttpPost]
        public IHttpActionResult Post(List<Taxes> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Taxes> list)
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
