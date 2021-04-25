﻿using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Schedules;
using BookStoreApi.Repositories.Concrect.Schedules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library
{
    public class ScheduleLineController : ApiController
    {
        readonly IScheduleLineRepository _repository = new ScheduleLineRepository();

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repository.Get());
        }

        [HttpGet]
        public IHttpActionResult Get(string idSchedule)
        {
            return Ok(_repository.GetBySchedule(idSchedule));
        }
        [HttpGet]
        public IHttpActionResult Get(string idSchedule,int month)
        {
            return Ok(_repository.GetBySchedule(idSchedule,month));
        }
        [HttpGet]
        public IHttpActionResult Get(string idSchedule, int month,int day)
        {
            return Ok(_repository.GetBySchedule(idSchedule, month,day));
        }
        [HttpPost]
        public IHttpActionResult Post(List<ScheduleLine> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<ScheduleLine> list)
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