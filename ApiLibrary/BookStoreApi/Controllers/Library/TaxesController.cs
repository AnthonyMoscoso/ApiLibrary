using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.Taxe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Taxe
{
    [RoutePrefix("Api/Taxes")]
    public class TaxesController : ApiController
    {
        public TaxesRepositorie _repository = new TaxesRepositorie();

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
