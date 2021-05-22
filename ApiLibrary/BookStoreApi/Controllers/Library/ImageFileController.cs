﻿using Models.Repositories.Concrect.Files;
using System.Collections.Generic;
using System.Web.Http;
using Models.Ado.Library;
using Ado.Library;

namespace Models.Controllers.Library.Files
{
    [RoutePrefix("Api/ImageFile")]
    public class ImageFileController : ApiController
    {
        readonly IImageFileRepositorie _repository = new ImageFileRepositorie();

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
        public IHttpActionResult Post(List<ImageFile> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<ImageFile> list)
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
