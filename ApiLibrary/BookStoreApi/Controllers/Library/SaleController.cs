using System;
using System.Collections.Generic;
using System.Web.Http;
using Negocios.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.Sales
{
    [RoutePrefix("Api/Sale")]
    public class SaleController : ApiController
    {
        readonly ISaleService _service ;

        public SaleController(ISaleService service)
        {
            _service = service;
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
        #region Buyer
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer)
        {
            return Ok(_service.GetByBuyer(idBuyer));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer,DateTime date)
        {
            return Ok(_service.GetByBuyer(idBuyer,date));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer, DateTime start,DateTime end)
        {
            return Ok(_service.GetByBuyer(idBuyer, start,end));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer,int pag,int element)
        {
            return Ok(_service.GetByBuyer(idBuyer,pag,element));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer,DateTime date, int pag, int element)
        {
            return Ok(_service.GetByBuyer(idBuyer,date, pag, element));
        }
        [HttpGet]
        [Route("Buyer")]
        public IHttpActionResult GetByBuyer(string idBuyer, DateTime start, DateTime end, int pag, int element)
        {
            return Ok(_service.GetByBuyer(idBuyer, start, end, pag, element));
        }
        #endregion

        #region Date
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date)
        {
            return Ok(_service.GetByDate(date));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime date,int pag,int element)
        {
            return Ok(_service.GetByDate(date,pag,element));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start,DateTime end)
        {
            return Ok(_service.GetByDate(start,end));
        }
        [HttpGet]
        [Route("Date")]
        public IHttpActionResult GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            return Ok(_service.GetByDate(start, end, pag, element));
        }
        #endregion

        #region PayMethod
        [HttpGet]
        [Route("PayMethod")]
        public IHttpActionResult GetByPayMethod(int payMethod)
        {
            return Ok(_service.GetByPayMethod(payMethod));
        }

        [HttpGet]
        [Route("PayMethod")]
        public IHttpActionResult GetByPayMethod(int payMethod,int pag,int element)
        {
            return Ok(_service.GetByPayMethod(payMethod,pag,element));
        }

        #endregion

        #region SaleStatus
        [HttpGet]
        [Route("SaleStatus")]
        public IHttpActionResult GetBySaleStatus(int SaleStatus)
        {
            return Ok(_service.GetBySaleStatus(SaleStatus));
        }

        [HttpGet]
        [Route("SaleStatus")]
        public IHttpActionResult GetBySaleStatus(int SaleStatus, int pag, int element)
        {
            return Ok(_service.GetBySaleStatus(SaleStatus, pag, element));
        }
     
  
        #endregion

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
        public IHttpActionResult Post(List<SaleDto> list)
        {
            return Ok(_service.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<SaleDto> list)
        {
            return Ok(_service.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_service.Delete(ids));
        }
    }
}
