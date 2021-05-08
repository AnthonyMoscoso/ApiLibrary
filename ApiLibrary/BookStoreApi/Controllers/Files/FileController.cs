using BookStoreApi.Models.Dtos;
using BookStoreApi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Files
{
    [RoutePrefix("api/File")]
    public class FileController : ApiController
    {
        readonly IFileRepository _repository = new FileRepository();

        [HttpGet]
        [Route("DownLoad")]
        public IHttpActionResult DownLoad(int type,string dir,string name)
        {
            return ResponseMessage(_repository.DownLoad(type,dir,name));
        }

        [HttpPost]
        [Route("Upload")]
        public IHttpActionResult Upload()
        {
            return Ok(_repository.Upload());
        }

        [HttpDelete]
        [Route("Delete")]
        public IHttpActionResult Delete(int type, string dir, string name,string format)
        {
            return Ok(_repository.Delete(type, dir, name,format));
        }
    }
}
