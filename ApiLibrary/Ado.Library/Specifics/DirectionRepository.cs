using Models.Dtos;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;

namespace Ado.Library.Specifics
{
    public class DirectionRepository : AdoRepository<Direction>, IDirectionRepository
    {
        public DirectionRepository(BookStoreEntities context,string identificator="IdDirection") : base(context,identificator)
        {
        }

    }
}