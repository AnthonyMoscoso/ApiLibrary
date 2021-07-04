using Models.Ado.Library;
using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IPersonService : IServices<PersonDto>
    {
        IEnumerable<Providers> SearchByName(string text);
        IEnumerable<Providers> SearchByName(string text, int pag, int element);
    }
}
