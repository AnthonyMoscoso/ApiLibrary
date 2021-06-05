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
    public class SocieService : ServiceMapperBase<SocieDto, Socie>, ISocieService
    {
        public SocieService(ISocieRepository repository) : base(repository)
        {
        }

        public IEnumerable<SocieDto> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SocieDto> GetByDate(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public SocieDto GetByDni(string dni)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SocieDto> GetDesactivates()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SocieDto> SearchByName(string text)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SocieDto> SearchByName(string text, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
