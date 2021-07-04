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
    public class ShippingLineService : ServiceMapperBase<ShippingLineDto, ShippingLine>, IShippingLineService
    {
        public ShippingLineService(IShippingLineRepository repository) : base(repository)
        {
        }
    }
}
