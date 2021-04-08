using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Editorials
{
    interface IEditorialRepositorie : IRepository<Editorial>
    {
        List<Editorial>SearchByName(string text);
        List<Editorial> SearchByName(string text,int pag,int element);
    }
}
