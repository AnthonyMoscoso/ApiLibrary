using Models.Ado.Library;
using System;
using System.Collections.Generic;
using Models.Dtos;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface ISocieRepository : IRepository<Socie>
    {
        Socie GetByDni(string dni);
        IEnumerable<Socie> GetByDate(DateTime date);
        IEnumerable<Socie> GetByDate(DateTime start, DateTime end);
        IEnumerable<Socie> GetDesactivates();
        IEnumerable<Socie> SearchByName(string text);
        IEnumerable<Socie> SearchByName(string text,int pag,int element);

      
    }
}
