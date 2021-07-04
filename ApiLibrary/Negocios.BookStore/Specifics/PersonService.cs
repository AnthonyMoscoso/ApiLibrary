using Models.Ado.Library;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.DBAccess.Ado;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Specifics
{
    public class PersonService : ServiceMapperBase<PersonDto, Person>, IPersonService
    {
        public PersonService(IRepository<Person> repository) : base(repository)
        {
        }

        public IEnumerable<Providers> SearchByName(string text)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Providers> SearchByName(string text, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
