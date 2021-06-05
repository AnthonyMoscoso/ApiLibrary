using Models.Ado.Library;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.DBAccess.Ado;
using Nucleo.Services.Abstracts;
using System.Collections.Generic;

namespace Negocios.BookStoreServices.Specifics
{
    public class EditorialService : ServiceMapperBase<EditorialDto, Editorial>, IEditorialService
    {
        public EditorialService(IRepository<Editorial> repository) : base(repository)
        {
        }

        public IEnumerable<EditorialDto> SearchByName(string text)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<EditorialDto> SearchByName(string text, int pag, int element)
        {
            throw new System.NotImplementedException();
        }
    }
}
