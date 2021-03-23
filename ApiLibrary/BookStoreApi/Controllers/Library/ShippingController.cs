using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.Shippings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Shippings
{
    [RoutePrefix("Api/Shipping")]
    public class ShippingController : ApiController
    {
        public ShippingRepositorie _repository = new ShippingRepositorie();

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
        #endregion

        #region Arrival
        [HttpGet]
        [Route("Arrival")]
        public IHttpActionResult GetByArrival (DateTime date)
        {
            return Ok(_repository.GetByArrivalDate(date));
        }
        [HttpGet]
        [Route("Arrival")]
        public IHttpActionResult GetByArrival(DateTime date,int pag,int element)
        {
            return Ok(_repository.GetByArrivalDate(date,pag,element));
        }
        [Route("Arrival")]
        public IHttpActionResult GetByArrival(DateTime start, DateTime end)
        {
            return Ok(_repository.GetByArrivalDate(start, end));
        }
        [HttpGet]
        [Route("Arrival")]
        public IHttpActionResult GetByArrival(DateTime start,DateTime end, int pag, int element)
        {
            return Ok(_repository.GetByArrivalDate(start,end, pag, element));
        }
        #endregion

        #region Book
        [HttpGet]
        [Route("Book")]
        public IHttpActionResult GetByBook(string idBook)
        {
            return Ok(_repository.GetByBook(idBook));
        }
        [HttpGet]
        [Route("Book")]
        public IHttpActionResult GetByBook(string idBook,int pag,int element)
        {
            return Ok(_repository.GetByBook(idBook,pag,element));
        }
        #endregion

        #region Departure 
        [HttpGet]
        [Route("Departure")]
        public IHttpActionResult GetByDeparture(DateTime date)
        {
            return Ok(_repository.GetByDepartureDate(date));
        }
        [HttpGet]
        [Route("Departure")]
        public IHttpActionResult GetByDeparture(DateTime date, int pag, int element)
        {
            return Ok(_repository.GetByDepartureDate(date, pag, element));
        }
        [Route("Departure")]
        public IHttpActionResult GetByDeparture(DateTime start, DateTime end)
        {
            return Ok(_repository.GetByDepartureDate(start, end));
        }
        [HttpGet]
        [Route("Departure")]
        public IHttpActionResult GetByDeparture(DateTime start, DateTime end, int pag, int element)
        {
            return Ok(_repository.GetByDepartureDate(start, end, pag, element));
        }

        #endregion

        #region Exit Address
        [HttpGet]
        [Route("Exit")]
        public IHttpActionResult GetByExitAddress(string idAddress)
        {
            return Ok(_repository.GetByExitAddress(idAddress));
        }
        [HttpGet]
        [Route("Exit")]
        public IHttpActionResult GetByExitAddress(string idAddress,int status)
        {
            return Ok(_repository.GetByExitAddress(idAddress,status));
        }
        [HttpGet]
        [Route("Exit")]
        public IHttpActionResult GetByExitAddress(string idAddress,int pag,int element)
        {
            return Ok(_repository.GetByExitAddress(idAddress,pag,element));
        }
        [HttpGet]
        [Route("Exit")]
        public IHttpActionResult GetByExitAddress(string idAddress,int status, int pag, int element)
        {
            return Ok(_repository.GetByExitAddress(idAddress,status, pag, element));
        }
        #endregion

        #region Recipient Address
        [HttpGet]
        [Route("Recipient")]
        public IHttpActionResult GetByRecipientAddress(string idAddress)
        {
            return Ok(_repository.GetByRecipientAddress(idAddress));
        }
        [HttpGet]
        [Route("Recipient")]
        public IHttpActionResult GetByRecipientAddress(string idAddress, int status)
        {
            return Ok(_repository.GetByRecipientAddress(idAddress, status));
        }
        [HttpGet]
        [Route("Recipient")]
        public IHttpActionResult GetByRecipientAddress(string idAddress, int pag, int element)
        {
            return Ok(_repository.GetByRecipientAddress(idAddress, pag, element));
        }
        [HttpGet]
        [Route("Recipient")]
        public IHttpActionResult GetByRecipientAddress(string idAddress, int status, int pag, int element)
        {
            return Ok(_repository.GetByRecipientAddress(idAddress, status, pag, element));
        }
        #endregion

        #region Status
        [HttpGet]
        [Route("Status")]
        public IHttpActionResult GetByStatus(int status)
        {
            return Ok(_repository.GetByStatus(status));
        }
        [HttpGet]
        [Route("Status")]
        public IHttpActionResult GetByStatus(int status,int pag,int element)
        {
            return Ok(_repository.GetByStatus(status,pag,element));
        }
        #endregion

        #region Post 
        [HttpPost]
        public IHttpActionResult Post(List<Shipping> list)
        {
            return Ok(_repository.Insert(list));
        }
        #endregion

        #region Put
        [HttpPut]
        public IHttpActionResult Put(List<Shipping> list)
        {
            return Ok(_repository.Update(list));
        }
        #endregion

        #region Delete 
        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_repository.Delete(ids));
        }
        #endregion
    }
}
