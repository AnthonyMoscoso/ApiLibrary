using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Registers
{
    interface IRegisterRepositorie : IRepository<Register>
    {
        List<RegisterDto> GetByDate(DateTime date);
        List<RegisterDto> GetByDate(DateTime date, int pag, int element);
        List<RegisterDto> GetByDate(DateTime dateStart, DateTime dateEnd);
        List<RegisterDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element);
        

    }
}
