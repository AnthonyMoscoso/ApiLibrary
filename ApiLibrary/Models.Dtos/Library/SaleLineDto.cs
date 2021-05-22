using System;

namespace Models.Dtos
{
    public class SaleLineDto
    {
        public string IdSaleLine { get; set; }
        public string IdSale { get; set; }
        public string IdBook { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> StatusLine { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }

    }
}