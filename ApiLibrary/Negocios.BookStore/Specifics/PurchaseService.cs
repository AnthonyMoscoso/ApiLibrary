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
using Ado.Library;
using Core.Logger.Abstracts;

namespace Business.BookStoreServices.Specifics
{
    public class PurchaseService : ServiceMapperBase<PurchaseDto, Purchase>, IPurchaseService
    {
        public PurchaseService(IPurchaseRepository repository) : base(repository)
        {
        }
    }
}
