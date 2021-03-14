using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Genders
{
    interface IGenderRepositorie : IRepositorie <Gender>
    {
        List<Gender> SearchByName(string text);
        List<Gender> SearchByName(string text,int pag,int element);
    }
}
