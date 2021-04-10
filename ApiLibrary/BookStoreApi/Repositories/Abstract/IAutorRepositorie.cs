using BookStoreApi.Dtos;
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
        List<AutorDto> SearchByName(string text);
        List<AutorDto> SearchByName(string text,int pag,int element);
        AutorDto GetByName(string name);
        bool ExistName(string name);
    }
}
