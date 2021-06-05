using System.Collections.Generic;
using System.Web.Http;
using Models.Ado.Library;
using Ado.Library;
using Ado.Library.Specifics;

namespace Models.Controllers.Library.BarCodes
{
    [RoutePrefix("Api/BarCode")]
    public class BarCodeController : ApiController
    {
        readonly IBarCodeRepository _service ;

        public BarCodeController(/*IBarCodeService service*/)
        {

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
        public IHttpActionResult Post(List<Barcode> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Barcode> list)
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
