using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IPermitService : IServices<PermitDto>
    {
        IEnumerable<PermitDto> SearchByName(string text);
        IEnumerable<PermitDto> SearchByName(string text, int pag, int element);
    }
}
