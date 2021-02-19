﻿using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStoreApi.Controllers.Library.Persons
{
    [RoutePrefix("Api/Employee")]
    public class EmployeeController : ApiController
    {
        public EmployeeRepositorie _repository = new EmployeeRepositorie();

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_repository.Get());
        }
        [HttpPost]
        public IHttpActionResult Get(List<string> ids)
        {
            return Ok(_repository.Get(ids));
        }

        [HttpGet]
        [Route("Pag")]
        public IHttpActionResult Get(int element, int page)
        {
            return Ok(_repository.Get(element, page));
        }
        [HttpPost]
        public IHttpActionResult Post(List<Employee> list)
        {
            return Ok(_repository.Insert(list));
        }

        [HttpPut]
        public IHttpActionResult Put(List<Employee> list)
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
