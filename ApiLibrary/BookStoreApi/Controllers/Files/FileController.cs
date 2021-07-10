using Business.FileServices.Abstracts;
using Core.FileService.Abstracts;
using Core.FileService.Enums;
using System;
using System.Web.Http;

namespace Core.FilesAcces
{
    [RoutePrefix("api/File")]
    public class FileController : ApiController
    {
        readonly IWebFileService _service;

        public FileController(IWebFileService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("DownLoad")]
        public IHttpActionResult DownLoad(string name,string dir,FileType type)
        {
            return ResponseMessage(_service.DonwloadFromWeb(name,dir,type));
        }

        [HttpPost]
        [Route("Upload")]
        public IHttpActionResult Upload()
        {
            return Ok(_service.UploadFromHttpRequest());
        }

        
    }
}
