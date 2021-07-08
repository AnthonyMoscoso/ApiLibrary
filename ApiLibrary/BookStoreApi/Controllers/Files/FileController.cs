using System.Web.Http;
using Core.Files.Web;

namespace Core.FilesAcces
{
    [RoutePrefix("api/File")]
    public class FileController : ApiController
    {
        readonly IFileRepository _repository;

        public FileController(IFileRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("DownLoad")]
        public IHttpActionResult DownLoad(string type,string dir,string name)
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
        public IHttpActionResult Delete(string dir, string name)
        {
            return Ok(_repository.Delete(dir, name));
        }
    }
}
