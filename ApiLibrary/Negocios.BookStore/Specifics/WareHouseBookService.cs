using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.DBAccess.Ado;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Specifics
{
    public class WareHouseBookService : ServiceMapperBase<WareHouseBookDto, WareHouseBook>, IWareHouseBookService
    {
        IWareHouseBookRepository _Irepository;
        public WareHouseBookService(IWareHouseBookRepository repository) : base(repository)
        {
        }

        public int GetStock(string idBook, string idStore)
        {
            return _Irepository.GetStock(idBook,idStore);
        }
    }
}
