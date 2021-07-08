using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.DBAccess.Ado;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Logger.Abstracts;

namespace Business.BookStoreServices.Specifics
{
    public class TaxesService : ServiceMapperBase<TaxesDto, Taxes>, ITaxesService
    {
        public TaxesService(ITaxesRepository repository) : base(repository)
        {
        }

        public IEnumerable<TaxesDto> GetByType(int type)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaxesDto> GetByType(int type, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaxesDto> SearchByName(string text)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaxesDto> SearchByName(string text, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
