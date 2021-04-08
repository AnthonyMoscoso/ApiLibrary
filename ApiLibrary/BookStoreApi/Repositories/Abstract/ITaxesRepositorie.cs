using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Taxe
{
    interface ITaxesRepositorie : IRepository <Taxes>
    {
        List<Taxes> SearchByName(string text);
        List<Taxes> SearchByName(string text,int pag,int element);
        List<Taxes> GetByType(int type);
        List<Taxes> GetByType(int type, int pag, int element);
    }
}
