using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IBookTypeService : IServices<BookTypeDto>
    {
        IEnumerable<BookTypeDto> SearchByName(string text);
        IEnumerable<BookTypeDto> SearchByName(string text, int pag, int element);
        BookTypeDto GetByName(string name);
    }
}
