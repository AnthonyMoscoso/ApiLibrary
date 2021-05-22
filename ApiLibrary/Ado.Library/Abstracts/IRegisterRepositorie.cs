using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IRegisterRepositorie : IRepository<Register>
    {
        List<RegisterDto> GetByDate(DateTime date);
        List<RegisterDto> GetByDate(DateTime date, int pag, int element);
        List<RegisterDto> GetByDate(DateTime dateStart, DateTime dateEnd);
        List<RegisterDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element);
        

    }
}
