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
    public class GenderService : ServiceMapperBase<GenderDto, Gender>, IGenderService
    {
        public GenderService(IGenderRepository repository) : base(repository)
        {
        }

        public IEnumerable<GenderDto> SearchByName(string text)
        {
            return Map(_repository.Get(w=> w.GenderName.Contains(text))); 
        }

        public IEnumerable<GenderDto> SearchByName(string text, int pag, int element)
        {
            return Map(_repository.Get(w => w.GenderName.Contains(text)).Skip((pag-1)*element).Take(element));

        }
    }
}
