using Core.Models.Abstracts;

namespace Models.Dtos
{
    public class BookEditorialDto : IEntity
    {
        public string IdBookEditorial { get; set; }
        public string IdBook { get; set; }
        public string IdEditorial { get; set; }
        public double PurchasePrice { get; set; }
        public bool IsDiscontinued { get; set; }
        public string _Id { get => IdBookEditorial; set => IdBookEditorial = value; }
    }
}