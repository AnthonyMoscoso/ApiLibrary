using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.BarCodes
{
    public class BarCodeRepository : Repository<Barcode,BarCodeDto>, IBarCodeRepository
    {
        public BarCodeRepository(string identificator= "IdBarcode") : base(identificator)
        {
        }
    }
}