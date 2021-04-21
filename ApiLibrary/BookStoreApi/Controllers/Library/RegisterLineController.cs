using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Registers;
using BookStoreApi.Repositories.Concrect.Registers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library
{
    [RoutePrefix("api/RegisterLine")]
    [Authorize]
    public class RegisterLineController : ApiController
    {
        readonly IRegisterLineRepository _repository = new RegisterLineRepository();

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

        [HttpPost]
        public IHttpActionResult Insert(List<RegisterLine> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Update(List<RegisterLine> list)
        {
            return Ok(_repository.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> list)
        {
            return Ok(_repository.Delete(list));
        }
    }
}
