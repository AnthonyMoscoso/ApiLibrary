using Models.Dtos;

namespace Models.Models.Dtos
{
    public class ReservationStoreDto : ReservationDto
    {
        public string IdStore { get; set; }
        public string IdEmployee { get; set; }
        public string IdStoreSale { get; set; }
    }
}