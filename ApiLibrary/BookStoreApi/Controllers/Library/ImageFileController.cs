using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Files;
using BookStoreApi.Repositories.Concrect.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Files
{
    [RoutePrefix("Api/ImageFile")]
    public class ImageFileController : ApiController
    {
        readonly IImageFileRepositorie _repository = new ImageFileRepositorie();

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
        public IHttpActionResult Get(int element, int pag)
        {
            return Ok(_repository.Get(element, pag));
        }
        [HttpPost]
        public IHttpActionResult Post(ImageFile imageFile)
        {
            return Ok(_repository.Insert(imageFile));
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
    }
}
