using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.BarCodes
{
    public class BarCodeRepositorie : Repositorie<Barcode>, IBarCodeRepositorie
    {
        public BarCodeRepositorie(string identificator= "IdBarcode") : base(identificator)
        {
        }
    }
}