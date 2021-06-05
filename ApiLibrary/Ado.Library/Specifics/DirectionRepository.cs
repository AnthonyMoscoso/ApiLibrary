using Models.Dtos;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{
    public class DirectionRepository : Repository<Direction>, IDirectionRepository
    {
        public DirectionRepository(BookStoreEntities context,string identificator="IdDirection") : base(context,identificator)
        {
        }

    }
}