using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Sales;
using BookStoreApi.Repositories.Concrect.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Sales
{
    [RoutePrefix("Api/Sale")]
    public class SaleController : ApiController
    {
        readonly ISaleRepository _repository = new SaleRepository();

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
        #region Buyer
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer)
        {
            return Ok(_repository.GetByBuyer(idBuyer));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer,DateTime date)
        {
            return Ok(_repository.GetByBuyer(idBuyer,date));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer, DateTime start,DateTime end)
        {
            return Ok(_repository.GetByBuyer(idBuyer, start,end));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer,int pag,int element)
        {
            return Ok(_repository.GetByBuyer(idBuyer,pag,element));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer,DateTime date, int pag, int element)
        {
            return Ok(_repository.GetByBuyer(idBuyer,date, pag, element));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer, DateTime start, DateTime end, int pag, int element)
        {
            return Ok(_repository.GetByBuyer(idBuyer, start, end, pag, element));
        }
        #endregion

        #region Date
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date)
        {
            return Ok(_repository.GetByDate(date));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date,int pag,int element)
        {
            return Ok(_repository.GetByDate(date,pag,element));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start,DateTime end)
        {
            return Ok(_repository.GetByDate(start,end));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            return Ok(_repository.GetByDate(start, end, pag, element));
        }
        #endregion

        #region PayMethod
        [HttpGet]
        [Route("PayMethod")]
        public IHttpActionResult GetByPayMethod(int payMethod)
        {
            return Ok(_repository.GetByPayMethod(payMethod));
        }

        [HttpGet]
        [Route("PayMethod")]
        public IHttpActionResult GetByPayMethod(int payMethod,int pag,int element)
        {
            return Ok(_repository.GetByPayMethod(payMethod,pag,element));
        }
        [HttpGet]
        [Route("PayMethod")]
        public IHttpActionResult GetByPayMethod(int payMethod,string idStore)
        {
            return Ok(_repository.GetByPayMethod(payMethod,idStore));
        }
        [HttpGet]
        [Route("PayMethod")]
        public IHttpActionResult GetByPayMethod(int payMethod,string idStore, int pag, int element)
        {
            return Ok(_repository.GetByPayMethod(payMethod,idStore, pag, element));
        }
        #endregion

        #region SaleStatus
        [HttpGet]
        [Route("SaleStatus")]
        public IHttpActionResult GetBySaleStatus(int SaleStatus)
        {
            return Ok(_repository.GetBySaleStatus(SaleStatus));
        }

        [HttpGet]
        [Route("SaleStatus")]
        public IHttpActionResult GetBySaleStatus(int SaleStatus, int pag, int element)
        {
            return Ok(_repository.GetBySaleStatus(SaleStatus, pag, element));
        }
        [HttpGet]
        [Route("SaleStatus")]
        public IHttpActionResult GetBySaleStatus(int SaleStatus, string idStore)
        {
            return Ok(_repository.GetBySaleStatus(SaleStatus, idStore));
        }
        [HttpGet]
        [Route("SaleStatus")]
        public IHttpActionResult GetBySaleStatus(int SaleStatus, string idStore, int pag, int element)
        {
            return Ok(_repository.GetBySaleStatus(SaleStatus, idStore, pag, element));
        }
        #endregion

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
        public IHttpActionResult Post(List<Sale> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Sale> list)
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
