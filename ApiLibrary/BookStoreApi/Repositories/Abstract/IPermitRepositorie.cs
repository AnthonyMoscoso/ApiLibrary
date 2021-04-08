using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Permits
{
    interface IPermitRepositorie : IRepository<Permit>
    {
        List<Permit> SearchByName(string text);
        List<Permit> SearchByName(string text,int pag,int element);
    }
}
