using Models.Repositories.Concrect.Stores;
using System.Collections.Generic;
using Models.Ado.Library;
using System.Web.Http;
using Ado.Library;

namespace Models.Controllers.Library.Stores
{
    [RoutePrefix("Api/Store")]
    public class StoreController : ApiController
    {
        readonly IStoreRepository _repository = new StoreRepository();

        #region Get
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
        public IHttpActionResult Get(int element, int pag)
        {
            return Ok(_repository.Get(element, pag));
        }
        #endregion

        #region Postal Code
        [HttpGet]
        [Route("PostalCode")]
        public IHttpActionResult GetByPostalCode(string code )
        {
            return Ok(_repository.GetByPostalCode(code));
        }
        [HttpGet]
        [Route("PostalCode")]
        public IHttpActionResult GetByPostalCode(string code,int pag,int element)
        {
            return Ok(_repository.GetByPostalCode(code,pag,element));
        }
        #endregion

        #region Country
        [HttpGet]
        [Route("Country")]
        public IHttpActionResult GetByCountry(string Country)
        {
            return Ok(_repository.GetByCountry(Country));
        }
        [HttpGet]
        [Route("Country")]
        public IHttpActionResult GetByCountry(string Country, int pag, int element)
        {
            return Ok(_repository.GetByCountry(Country, pag, element));
        }
        #endregion

        #region Poblation
        [HttpGet]
        [Route("Poblation")]
        public IHttpActionResult GetByPoblation(string Poblation)
        {
            return Ok(_repository.GetByPoblation(Poblation));
        }
        [HttpGet]
        [Route("Poblation")]
        public IHttpActionResult GetByPoblation(string Poblation, int pag, int element)
        {
            return Ok(_repository.GetByPoblation(Poblation, pag, element));
        }
        #endregion

        #region Employee 
        [HttpGet]
        [Route("Employee")]
        public IHttpActionResult GetByEmployee(string idEmployee)
        {
            return Ok(_repository.GetByEmployee(idEmployee));
        }
        #endregion

        [HttpPost]
        public IHttpActionResult Post(List<Store> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Store> list)
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
