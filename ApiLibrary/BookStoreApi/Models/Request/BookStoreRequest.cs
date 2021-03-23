using BookStoreApi.Models.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Request
{
    public class BookStoreRequest
    {
        public string IdBook { get; set; }
        public string IdType { get; set; }
        public string IdEdition { get; set; }
        public string BookTittle { get; set; }
        public string Languages { get; set; }
        public DateTime PublicationDate { get; set; }
        public int Pags { get; set; }
        public string ISBM { get; set; }
        public int EditionNum { get; set; }
        public string Synopsis { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public int BindingType { get; set; }
        public int Stock { get; set; }
        public string IdStore { get; set; }

        public Store Store { get; set; }
        public Barcode Barcode { get; set; }
        public Edition Edition { get; set; }
        public BookType BookType { get; set; }     
        public List<Autor> Autor { get; set; }
        public Discount Discount { get; set; }
        public List<Gender> Gender { get; set; }
        public ImageFile ImageFile { get; set; }
    }
}