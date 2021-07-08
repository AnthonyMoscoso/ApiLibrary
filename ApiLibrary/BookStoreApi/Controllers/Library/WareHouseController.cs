using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using System.Collections.Generic;
using System.Web.Http;
using System.Net;

namespace Models.Controllers.Library.WareHouses
{
    [RoutePrefix("Api/WareHouse")]
    [Authorize]
    public class WareHouseController : ApiController
    {
        readonly IWareHouseService _service;


        public WareHouseController(IWareHouseService service)
        {
            _service = service;
        }

        #region Get
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Content(HttpStatusCode.OK,_service.Get());
        }
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            return Content(HttpStatusCode.OK,_service.Get(id));
        }

        [HttpGet]
        public IHttpActionResult GetList(string ids)
        {
            return Content(HttpStatusCode.OK,_service.GetList(ids));
        }

        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int pag)
        {
            return Content(HttpStatusCode.OK,_service.Get(element, pag));
        }
        #endregion



        #region Postal Code
        [HttpGet]
        [Route("PostalCode")]
        public IHttpActionResult GetByPostalCode(string code)
        {
            return Content(HttpStatusCode.OK,_service.GetByPostalCode(code));
        }
        [HttpGet]
        [Route("PostalCode")]
        public IHttpActionResult GetByPostalCode(string code, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByPostalCode(code, pag, element));
        }
        #endregion

        #region Country
        [HttpGet]
        [Route("Country")]
        public IHttpActionResult GetByCountry(string Country)
        {
            return Content(HttpStatusCode.OK,_service.GetByCountry(Country));
        }
        [HttpGet]
        [Route("Country")]
        public IHttpActionResult GetByCountry(string Country, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByCountry(Country, pag, element));
        }
        #endregion

        #region Poblation
        [HttpGet]
        [Route("Poblation")]
        public IHttpActionResult GetByPoblation(string Poblation)
        {
            return Content(HttpStatusCode.OK,_service.GetByPoblation(Poblation));
        }
        [HttpGet]
        [Route("Poblation")]
        public IHttpActionResult GetByPoblation(string Poblation, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByPoblation(Poblation, pag, element));
        }
        #endregion

        #region Employee 
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee)
        {
            return Content(HttpStatusCode.OK,_service.GetByEmployee(idEmployee));
        }
        #endregion
        [HttpPost]
        public IHttpActionResult Post(List<WareHouseDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<WareHouseDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Content(HttpStatusCode.OK,_service.Delete(ids));
        }
    }
}
