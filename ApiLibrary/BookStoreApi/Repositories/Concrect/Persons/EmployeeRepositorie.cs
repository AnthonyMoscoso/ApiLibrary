﻿using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Persons;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Persons
{
    public class EmployeeRepositorie : Repositorie<Employee>, IEmployeeRepositorie
    {
        public EmployeeRepositorie(string identificator="IdEmployee") : base(identificator)
        {
        }
    }
}