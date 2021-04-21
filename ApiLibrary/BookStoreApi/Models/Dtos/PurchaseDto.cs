using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class PurchaseDto
    {
        public string IdPurchase { get; set; }
        public string IdEditorial { get; set; }
        public string IdEmployee { get; set; }
        public int PurchaseStatus { get; set; }
        public double Total { get; set; }
        public Nullable<System.DateTime> ExpectArrivalDate { get; set; }
        public Nullable<System.DateTime> ArrivalDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }

        public List<PurchaseLineDto> PurchaseLine { get; set; }
    }
}