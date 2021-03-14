using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Editions
{
    interface IEditionRepositorie : IRepositorie<Edition>
    {
      List<Edition>  SearchByName(string text);

       List<Edition> SearchByName(string text,int pag,int element);
    }
}
