using BookStoreApi.Models.Library;
using BookStoreApi.Models.Request;
using BookStoreApi.Repositories.Abstract.Persons;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Persons
{
    public class PersonRepository : Repository<Person,PersonDto>, IPersonRepository
    {
        public PersonRepository(string identificator="IdPerson") : base(identificator)
        {
        }
    }
}