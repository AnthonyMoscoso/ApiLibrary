using Ado.Library;
using LibraryApiRest.Repositories.Concrect;
using Models.Ado.Library;
using System.Collections.Generic;
using System.Web.Http;

namespace Models.Controllers
{

    [RoutePrefix("Api/Autor")]
    [Authorize]
    public class AutorController : ApiController 
    {

        readonly IAutorRepository _repository = new AutorRepository();

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
        public IHttpActionResult Post(List<Autor> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Autor> list)
        {
            return Ok(_repository.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_repository.Delete(ids));
        }

        #endregion

        [HttpGet]
        [Route("Name")]
        public IHttpActionResult GetByName(string name)
        {
            return Ok(_repository.GetByName(name));
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
        [Route("ExistName")]
        public IHttpActionResult ExistName(string name)
        {
            return Ok(_repository.ExistName(name));
        }



   


    }
}
