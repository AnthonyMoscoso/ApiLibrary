using BookStoreApi.Models.Library;
using BookStoreApi.Models.Request;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Persons
{
    interface ISocieRepositorie : IRepository<Socie>
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
    }
}
