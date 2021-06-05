using Models.Ado.Library;
using Models.Dtos;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{ 
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(BookStoreEntities context,string identificator="IdPerson") : base(context,identificator)
        {
        }
    }
}