using Models.Ado.Library;
using Models.Dtos;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Persons
{
    public class PersonRepository : Repository<Person,PersonDto>, IPersonRepository
    {
        public PersonRepository(string identificator="IdPerson") : base(identificator)
        {
        }
    }
}