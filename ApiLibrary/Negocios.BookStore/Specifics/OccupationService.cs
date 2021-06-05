using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.DBAccess.Ado;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Specifics
{
    public class OccupationService : ServiceMapperBase<OccupationDto, Occupation>, IOccupationService
    {
        public OccupationService(IOccupationRepository repository) : base(repository)
        {
        }

        public IEnumerable<OccupationDto> SearchByName(string text)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OccupationDto> SearchByName(string text, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
