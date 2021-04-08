using BookStoreApi.Dtos;
using BookStoreApi.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library
{
    [RoutePrefix("api/StoreSale")]
    [Authorize]
    public class StoreSaleController : ApiController
    {
        readonly StoreSaleRepository _repository;
        public StoreSaleController()
        {
            _repository = new StoreSaleRepository();
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
        #region Buyer
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer)
        {
            return Ok(_repository.GetByBuyer(idBuyer));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer, DateTime date)
        {
            return Ok(_repository.GetByBuyer(idBuyer, date));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer, DateTime start, DateTime end)
        {
            return Ok(_repository.GetByBuyer(idBuyer, start, end));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer, int pag, int element)
        {
            return Ok(_repository.GetByBuyer(idBuyer, pag, element));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer, DateTime date, int pag, int element)
        {
            return Ok(_repository.GetByBuyer(idBuyer, date, pag, element));
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
        public IHttpActionResult GetByDate(DateTime date, int pag, int element)
        {
            return Ok(_repository.GetByDate(date, pag, element));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start, DateTime end)
        {
            return Ok(_repository.GetByDate(start, end));
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
        public IHttpActionResult GetByPayMethod(int payMethod, int pag, int element)
        {
            return Ok(_repository.GetByPayMethod(payMethod, pag, element));
        }
        [HttpGet]
        [Route("PayMethod")]
        public IHttpActionResult GetByPayMethod(int payMethod, string idStore)
        {
            return Ok(_repository.GetByPayMethod(payMethod, idStore));
        }
        [HttpGet]
        [Route("PayMethod")]
        public IHttpActionResult GetByPayMethod(int payMethod, string idStore, int pag, int element)
        {
            return Ok(_repository.GetByPayMethod(payMethod, idStore, pag, element));
        }
        #endregion

        #region SaleStatus
        [HttpGet]
        [Route("Status")]
        public IHttpActionResult GetBySaleStatus(int SaleStatus)
        {
            return Ok(_repository.GetByStatus(SaleStatus));
        }

        [HttpGet]
        [Route("Status")]
        public IHttpActionResult GetByStatus(int SaleStatus, int pag, int element)
        {
            return Ok(_repository.GetByStatus(SaleStatus, pag, element));
        }
        [HttpGet]
        [Route("Status")]
        public IHttpActionResult GetBytatus(int SaleStatus, string idStore)
        {
            return Ok(_repository.GetByStatus(SaleStatus, idStore));
        }
        [HttpGet]
        [Route("Status")]
        public IHttpActionResult GetByStatus(int SaleStatus, string idStore, int pag, int element)
        {
            return Ok(_repository.GetByStatus(SaleStatus, idStore, pag, element));
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
        public IHttpActionResult GetByStore(string idStore, int pag, int element)
        {
            return Ok(_repository.GetByStore(idStore, pag, element));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore, DateTime date)
        {
            return Ok(_repository.GetByStore(idStore, date));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore, DateTime date, int pag, int element)
        {
            return Ok(_repository.GetByStore(idStore, date, pag, element));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore, DateTime start, DateTime end)
        {
            return Ok(_repository.GetByStore(idStore, start, end));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            return Ok(_repository.GetByStore(idStore, start, end, pag, element));
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
        public IHttpActionResult Get(int element, int pag)
        {
            return Ok(_repository.Get(element, pag));
        }
        [HttpPost]
        public IHttpActionResult Post(List<StoreSaleDto> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<StoreSaleDto> list)
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
