﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Business.BookStoreServices.Abstracts;
using Models.Dtos;

namespace Models.Controllers.Library.Shippings
{
    [RoutePrefix("Api/Shipping")]
    [Authorize]
    public class ShippingController : ApiController
    {
        readonly IShippingService _service ;

        public ShippingController(IShippingService service)
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

        #region Arrival
        [HttpGet]
        [Route("Arrival")]
        public IHttpActionResult GetByArrival (DateTime date)
        {
            return Content(HttpStatusCode.OK,_service.GetByArrivalDate(date));
        }
        [HttpGet]
        [Route("Arrival")]
        public IHttpActionResult GetByArrival(DateTime date,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByArrivalDate(date,pag,element));
        }
        [Route("Arrival")]
        public IHttpActionResult GetByArrival(DateTime start, DateTime end)
        {
            return Content(HttpStatusCode.OK,_service.GetByArrivalDate(start, end));
        }
        [HttpGet]
        [Route("Arrival")]
        public IHttpActionResult GetByArrival(DateTime start,DateTime end, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByArrivalDate(start,end, pag, element));
        }
        #endregion

        #region Book
        [HttpGet]
        [Route("Book")]
        public IHttpActionResult GetByBook(string idBook)
        {
            return Content(HttpStatusCode.OK,_service.GetByBook(idBook));
        }
        [HttpGet]
        [Route("Book")]
        public IHttpActionResult GetByBook(string idBook,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByBook(idBook,pag,element));
        }
        #endregion

        #region Departure 
        [HttpGet]
        [Route("Departure")]
        public IHttpActionResult GetByDeparture(DateTime date)
        {
            return Content(HttpStatusCode.OK,_service.GetByDepartureDate(date));
        }
        [HttpGet]
        [Route("Departure")]
        public IHttpActionResult GetByDeparture(DateTime date, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByDepartureDate(date, pag, element));
        }
        [Route("Departure")]
        public IHttpActionResult GetByDeparture(DateTime start, DateTime end)
        {
            return Content(HttpStatusCode.OK,_service.GetByDepartureDate(start, end));
        }
        [HttpGet]
        [Route("Departure")]
        public IHttpActionResult GetByDeparture(DateTime start, DateTime end, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByDepartureDate(start, end, pag, element));
        }

        #endregion

        #region Exit Address
        [HttpGet]
        [Route("Exit")]
        public IHttpActionResult GetByExitAddress(string idAddress)
        {
            return Content(HttpStatusCode.OK,_service.GetByExitAddress(idAddress));
        }
        [HttpGet]
        [Route("Exit")]
        public IHttpActionResult GetByExitAddress(string idAddress,int status)
        {
            return Content(HttpStatusCode.OK,_service.GetByExitAddress(idAddress,status));
        }
        [HttpGet]
        [Route("Exit")]
        public IHttpActionResult GetByExitAddress(string idAddress,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByExitAddress(idAddress,pag,element));
        }
        [HttpGet]
        [Route("Exit")]
        public IHttpActionResult GetByExitAddress(string idAddress,int status, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByExitAddress(idAddress,status, pag, element));
        }
        #endregion

        #region Recipient Address
        [HttpGet]
        [Route("Recipient")]
        public IHttpActionResult GetByRecipientAddress(string idAddress)
        {
            return Content(HttpStatusCode.OK,_service.GetByRecipientAddress(idAddress));
        }
        [HttpGet]
        [Route("Recipient")]
        public IHttpActionResult GetByRecipientAddress(string idAddress, int status)
        {
            return Content(HttpStatusCode.OK,_service.GetByRecipientAddress(idAddress, status));
        }
        [HttpGet]
        [Route("Recipient")]
        public IHttpActionResult GetByRecipientAddress(string idAddress, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByRecipientAddress(idAddress, pag, element));
        }
        [HttpGet]
        [Route("Recipient")]
        public IHttpActionResult GetByRecipientAddress(string idAddress, int status, int pag, int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByRecipientAddress(idAddress, status, pag, element));
        }
        #endregion

        #region Status
        [HttpGet]
        [Route("Status")]
        public IHttpActionResult GetByStatus(int status)
        {
            return Content(HttpStatusCode.OK,_service.GetByStatus(status));
        }
        [HttpGet]
        [Route("Status")]
        public IHttpActionResult GetByStatus(int status,int pag,int element)
        {
            return Content(HttpStatusCode.OK,_service.GetByStatus(status,pag,element));
        }
        #endregion

        #region Post 
        [HttpPost]
        public IHttpActionResult Post(List<ShippingDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Insert(list));
        }
        #endregion

        #region Put
        [HttpPut]
        public IHttpActionResult Put(List<ShippingDto> list)
        {
            return Content(HttpStatusCode.OK,_service.Update(list));
        }
        #endregion

        #region Delete 
        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Content(HttpStatusCode.OK,_service.Delete(ids));
        }
        #endregion
    }
}
