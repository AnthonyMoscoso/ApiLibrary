﻿using System.Collections.Generic;
using System.Web.Http;
using Negocios.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.Purchases
{
    [RoutePrefix("Api/Purchase")]
    public class PurchaseController : ApiController
    {
        readonly IPurchaseService _service ;

        public PurchaseController(IPurchaseService service)
        {
            _service = service;
        }

        #region Generics 
        [HttpGet]
        [Route("Count")]
        public IHttpActionResult Count()
        {
            return Ok(_service.Count());
        }
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

        [HttpGet]
        public IHttpActionResult GetList(string ids)
        {
            return Ok(_service.GetList(ids));
        }

        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int pag)
        {
            return Ok(_service.Get(element, pag));
        }

        [HttpPost]
        public IHttpActionResult Post(List<PurchaseDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<PurchaseDto> list)
        {
            return Ok(_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_service.Delete(ids));
        }

        #endregion

    }
}
