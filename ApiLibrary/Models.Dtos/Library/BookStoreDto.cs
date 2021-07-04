using Core.Models.Abstracts;

namespace Models.Dtos
{
    public class BookStoreDto : IEntity 
    {
        public string IdBookStore { get; set; }
        public string IdBook { get; set; }
        public string IdStore { get; set; }
        public double BookPrice { get; set; }
        public int Stock { get; set; }
        public string _Id { get => IdBookStore; set => IdBookStore = value; }
    }
}