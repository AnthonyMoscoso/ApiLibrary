using Models.Ado.Library;
using Models.Dtos;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IGenderRepositorie : IRepository <Gender>
    {
        List<GenderDto> SearchByName(string text);
        List<GenderDto> SearchByName(string text,int pag,int element);
    }
}
