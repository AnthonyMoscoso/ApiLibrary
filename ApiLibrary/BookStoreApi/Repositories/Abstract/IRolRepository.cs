using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Rols
{
    interface IRolRepository : IRepository<Rol>
    {
        List<Rol> SearchByName(string text);
        List<Rol> SearchByName(string text,int pag,int element);
    }
}
