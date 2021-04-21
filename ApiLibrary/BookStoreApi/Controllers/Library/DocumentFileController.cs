﻿using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Files;
using BookStoreApi.Repositories.Concrect.Files;
using System.Collections.Generic;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Files
{
    [RoutePrefix("Api/DocumentFile")]
    public class DocumentFileController : ApiController
    {
        readonly IDocumentFileRepositorie _repository = new DocumentFileRepositorie();

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repository.Get());
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
        public IHttpActionResult Post(List<DocumentFile> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<DocumentFile> list)
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
