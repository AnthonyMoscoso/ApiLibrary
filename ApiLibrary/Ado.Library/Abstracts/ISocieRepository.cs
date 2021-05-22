using Models.Ado.Library;
using System;
using System.Collections.Generic;
using Models.Dtos;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface ISocieRepository : IRepository<Socie>
    {
        SocieDto GetByDni(string dni);
        List<SocieDto> GetByDate(DateTime date);
        List<SocieDto> GetByDate(DateTime start, DateTime end);
        List<SocieDto> GetDesactivates();
        dynamic DeleteDesactivates();
        void DesactivateAccount(string idSocie);
        void ReactivateAccount(string idSocie);
        List<SocieDto> SearchByName(string text);
        List<SocieDto> SearchByName(string text,int pag,int element);

        dynamic Insert(List<SocieDto> list);
        dynamic Update(List<SocieDto> list);
    }
}
