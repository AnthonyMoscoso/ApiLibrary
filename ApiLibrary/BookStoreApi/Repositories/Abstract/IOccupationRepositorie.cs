using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Occupations
{
    interface IOccupationRepositorie : IRepositorie<Occupation>
    {
        List<Occupation> SearchByName(string text);
        List<Occupation> SearchByName(string text,int pag,int element);
    }
}
