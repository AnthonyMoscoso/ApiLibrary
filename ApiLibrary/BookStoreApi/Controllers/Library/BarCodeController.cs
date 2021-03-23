using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.BarCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.BarCodes
{
    [RoutePrefix("Api/BarCode")]
    public class BarCodeController : ApiController
    {
        public BarCodeRepositorie _repository = new BarCodeRepositorie();

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repository.Get());
        }
        [HttpGet]
        [Route("List")]
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
        public IHttpActionResult Post(List<Barcode> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Barcode> list)
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
