using Models.Ado.Library;
using Models.Models.Dtos;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IRegisterStoreRepository : IRepository<Register>
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
