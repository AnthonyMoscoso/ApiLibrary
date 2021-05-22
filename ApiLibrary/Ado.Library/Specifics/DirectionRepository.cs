using Models.Dtos;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Directions
{
    public class DirectionRepository : Repository<Direction,DirectionDto>, IDirectionRepository
    {
        public DirectionRepository(string identificator="IdDirection") : base(identificator)
        {
        }

    }
}