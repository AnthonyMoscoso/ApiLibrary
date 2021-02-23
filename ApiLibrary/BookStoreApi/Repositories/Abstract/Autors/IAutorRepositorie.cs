using BookStoreApi.Models;
using BookStoreApi.Models.Library;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApiRest.Repositories.Abstract
{
    interface IAutorRepositorie : IRepositorie<Autor>
    {
        List<Autor> GetAutorLikeName(string text);
    }
}
