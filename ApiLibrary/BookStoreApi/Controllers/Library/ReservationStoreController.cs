﻿using Ado.Library;
using Models.Models.Dtos;
using Models.Repositories.Abstract;
using Models.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Models.Controllers.Library
{
    [RoutePrefix("api/ReservationStore")]
    [Authorize]
    public class ReservationStoreController : ApiController
    {
        readonly IReservationStoreRepository _repository = new ReservationStoreRepository();

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
        public IHttpActionResult Insert(List<ReservationStoreDto> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Update(List<ReservationStoreDto> list)
        {

            return Ok(_repository.Update(list));
        }

        [HttpDelete]
        public IHttpActionResult Delete(List<string> ids)
        {
            return Ok(_repository.Delete(ids));
        }
        #endregion

        #region Store
        [HttpGet]
        [Route("Store/{idStore}")]
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

        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore, DateTime start, DateTime end)
        {
            return Ok(_repository.GetByStore(idStore, start, end));
        }
        [HttpGet]
        [Route("Store")]
        public IHttpActionResult GetByStore(string idStore, DateTime start,DateTime end, int pag, int element)
        {
            return Ok(_repository.GetByStore(idStore,start,end,pag,element));
        }

        #endregion

        #region Count

        [HttpGet]

        [Route("Count/Store/{idStore}")]
        public IHttpActionResult Count(string idStore)
        {
            return Ok( _repository.Count(idStore));
        }
        [HttpGet]

        [Route("Count/Store/{idStore},{start},{end}")]
        public IHttpActionResult Count(string idStore,DateTime start,DateTime end)
        {
            return Ok(_repository.Count(idStore,start,end));
        }
        #endregion
    }
}