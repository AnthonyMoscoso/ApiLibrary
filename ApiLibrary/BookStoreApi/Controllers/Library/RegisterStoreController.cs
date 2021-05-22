using Ado.Library;
using Models.Models.Dtos;
using Models.Repositories.Abstract;
using Models.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Models.Controllers.Library
{
    [RoutePrefix("Api/RegisterStore")]
    [Authorize]
    public class RegisterStoreController : ApiController
    {
        readonly IRegisterStoreRepository _repository = new RegisterStoreRepository();

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
        public IHttpActionResult Get(int element, int pag)
        {
            return Ok(_repository.Get(element, pag));
        }

        [HttpPost]
        public IHttpActionResult Post(List<RegisterStoreDto> list)
        {
            return Ok(_repository.Insert(list));
        }
        [HttpPut]
        public IHttpActionResult Put(List<RegisterStoreDto> list)
        {
            return Ok(_repository.Update(list));
        }
        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_repository.Delete(ids));
        }

        #endregion

        [HttpGet]
        public IHttpActionResult GetByStore(string idStore)
        {
            return Ok(_repository.GetByStore(idStore));
        }

        [HttpGet]
        public IHttpActionResult Get(string idStore,int pag,int element)
        {
            return Ok(_repository.GetByStore(idStore,pag,element));
        }
        [HttpGet]
        public IHttpActionResult Get(string idStore,DateTime date)
        {
            return Ok(_repository.GetByStore(idStore,date));
        }
        [HttpGet]
        public IHttpActionResult Get(string idStore,DateTime date,int pag,int element)
        {
            return Ok(_repository.GetByStore(idStore,date,pag,element));
        }
        [HttpGet]
        public IHttpActionResult Get(string idStore, DateTime start, DateTime end)
        {
            return Ok(_repository.GetByStore(idStore, start, end));
        }
        [HttpGet]
        public IHttpActionResult Get(string idStore, DateTime start,DateTime end, int pag, int element)
        {
            return Ok(_repository.GetByStore(idStore, start,end, pag, element));
        }
      
    }
}
