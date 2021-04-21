using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Returns;
using BookStoreApi.Repositories.Concrect.Returns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Returns
{
    [RoutePrefix("Api/Return")]
    public class ReturnController : ApiController 
    {
        readonly IReturnSaleRepository _repository = new ReturnSaleRepository();

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

        #region Date
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date)
        {
            return Ok(_repository.GetByDate(date));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start,DateTime end)
        {
            return Ok(_repository.GetByDate(start,end));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date,int pag,int element)
        {
            return Ok(_repository.GetByDate(date,pag,element));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start,DateTime end, int pag, int element)
        {
            return Ok(_repository.GetByDate(start,end, pag, element));
        }
        #endregion

        #region Method
        [HttpGet]
        [Route("Method")]
        public IHttpActionResult GetByMethod(int method)
        {
            return Ok(_repository.GetByMethod(method));
        }
        [HttpGet]
        [Route("Method")]
        public IHttpActionResult GetByMethod(int method, string idStore)
        {
            return Ok(_repository.GetByMethod(method, idStore));
        }
        [HttpGet]
        [Route("Method")]
        public IHttpActionResult GetByMethod(int method,int pag,int element)
        {
            return Ok(_repository.GetByMethod(method,pag,element));
        }
        [HttpGet]
        [Route("Method")]
        public IHttpActionResult GetByMethod(int method,string idStore, int pag, int element)
        {
            return Ok(_repository.GetByMethod(method,idStore, pag, element));
        }
        #endregion

        #region Motive
        [HttpGet]
        [Route("Motive")]
        public IHttpActionResult GetByMotive(string motive)
        {
            return Ok(_repository.GetByMotive(motive));
        }
        [HttpGet]
        [Route("Motive")]
        public IHttpActionResult GetByMotive(string motive,string idStore)
        {
            return Ok(_repository.GetByMotive(motive,idStore));
        }
        [HttpGet]
        [Route("Motive")]
        public IHttpActionResult GetByMotive(string motive,int pag,int element)
        {
            return Ok(_repository.GetByMotive(motive,pag,element));
        }
        [HttpGet]
        [Route("Motive")]
        public IHttpActionResult GetByMotive(string motive,string idStore, int pag, int element)
        {
            return Ok(_repository.GetByMotive(motive,idStore, pag, element));
        }
        #endregion

        #region Sale 
        [HttpGet]
        [Route("Sale")]
        public IHttpActionResult GetBySale(string idSale)
        {
            return Ok(_repository.GetBySale(idSale));
        }
        #endregion

        #region Store 
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore)
        {
            return Ok(_repository.GetByStore(idStore));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore,int pag,int element)
        {
            return Ok(_repository.GetByStore(idStore,pag,element));
        }
        #endregion

        [HttpGet]
        [Route("List")]
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
        public IHttpActionResult Post(List<ReturnSale> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<ReturnSale> list)
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
