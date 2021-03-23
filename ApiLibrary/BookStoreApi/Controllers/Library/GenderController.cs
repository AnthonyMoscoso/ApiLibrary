using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.Genders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Genders
{
    [RoutePrefix("Api/Gender")]
    public class GenderController : ApiController
    {
        public GenderRepositorie _repository = new GenderRepositorie();

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
        [Route("List")]
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
        public IHttpActionResult Post(List<Gender> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Gender> list)
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
