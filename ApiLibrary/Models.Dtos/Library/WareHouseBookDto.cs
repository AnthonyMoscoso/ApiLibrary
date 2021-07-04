using Core.Models.Abstracts;

namespace Models.Dtos
{
    public class WareHouseBookDto : IEntity
    {
        public string IdWareHouseBook { get; set; }
        public string IdWareHouse { get; set; }
        public string IdBook { get; set; }
        public int Stock { get; set; }
        public string _Id { get => IdWareHouseBook; set => IdWareHouseBook = value; }
    }
}