using BookStoreApi.Models;
using BookStoreApi.Models.Library;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApiRest.Repositories.Abstract
{
    interface IAutorRepositorie : IRepository<Autor>
    {
        List<Autor> SearchByName(string text);
        List<Autor> SearchByName(string text,int pag,int element);
        Autor GetByName(string name);
        bool ExistName(string name);
    }
}
