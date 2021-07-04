using Core.Models.Abstracts;

namespace Models.Dtos
{
    public class StoreSaleDto : SaleDto ,IEntity
    {
        public string IdStore { get; set; }
        public string IdSeller { get; set; }
        public string _Id { get => IdStore; set => IdStore = value; }
    }
}