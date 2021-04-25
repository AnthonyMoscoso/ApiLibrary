using BookStoreApi.Models.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Concrect;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract
{
    interface IRegisterStoreRepository : IRepository<Register>
    {
        new List<RegisterStoreDto> Get();
        List<RegisterStoreDto> GetByStore(string idStore);
        List<RegisterStoreDto> GetByStore(string idStore,int pag,int element);
        List<RegisterStoreDto> GetByStore(string idStore,DateTime date);
        List<RegisterStoreDto> GetByStore(string idStore,DateTime date,int pag,int element);
        List<RegisterStoreDto> GetByStore(string idStore,DateTime start,DateTime end);
        List<RegisterStoreDto> GetByStore(string idStore, DateTime start, DateTime end,int pag,int element);


        dynamic Insert(List<RegisterStoreDto> list);
        dynamic Update(List<RegisterStoreDto> list);
    }
}
