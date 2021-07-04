using Models.Ado.Library;
using Models.Dtos;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;

namespace Ado.Library.Specifics
{ 
    public class PersonRepository : AdoRepository<Person>, IPersonRepository
    {
        public PersonRepository(BookStoreEntities context, string identificator="IdPerson") : base(context,identificator)
        {
        }
    }
}