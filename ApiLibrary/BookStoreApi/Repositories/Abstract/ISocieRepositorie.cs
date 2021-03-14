using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Persons
{
    interface ISocieRepositorie : IRepositorie<Socie>
    {
        List<Socie> GetByDni(string dni);
        List<Socie> GetByDate(DateTime date);
        List<Socie> GetByDate(DateTime start, DateTime end);
        List<Socie> GetDesactivates();
        dynamic DeleteDesactivates();
        void DesactivateAccount(string idSocie);
        void ReactivateAccount(string idSocie);
        List<Socie>SearchByName(string text);
        List<Socie> SearchByName(string text,int pag,int element);
    }
}
