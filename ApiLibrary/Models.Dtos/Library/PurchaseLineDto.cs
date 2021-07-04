using Core.Models.Abstracts;

namespace Models.Dtos
{
    public class PurchaseLineDto : IEntity
    {
        public string IdPurchaseLine { get; set; }
        public string IdPurchase { get; set; }
        public string IdBook { get; set; }
        public double BookPurchasePrice { get; set; }
        public int Quantity { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string _Id { get => IdPurchaseLine; set => IdPurchaseLine = value; }
    }
}