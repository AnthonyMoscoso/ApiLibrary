using Ado.Library.Specifics;
using Models.Ado.Library;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;

namespace Negocios.BookStoreServices.Specifics
{
    public class DiscountService : ServiceMapperBase<DiscountDto, Discount>, IDiscountService
    {
        public DiscountService(DiscountRepository repository) : base(repository)
        {
        }

        public DiscountDto GetByBook(string idBook)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DiscountDto> GetFinnalized()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DiscountDto> GetFinnalized(int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DiscountDto> GetNotFinnalized()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DiscountDto> GetNotFinnalized(int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
