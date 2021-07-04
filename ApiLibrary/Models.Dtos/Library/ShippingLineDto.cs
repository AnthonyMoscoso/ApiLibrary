using Core.Models.Abstracts;

namespace Models.Dtos
{
    public class ShippingLineDto : IEntity
    {
        public string IdShippingLine { get; set; }
        public string IdShipping { get; set; }
        public string IdBook { get; set; }
        public int Quantity { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string _Id { get => IdShippingLine; set => IdShippingLine = value; }
    }
}