using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.DBAccess.Ado;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Specifics
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
