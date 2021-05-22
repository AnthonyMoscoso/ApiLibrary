using Models.Dtos;

namespace Models.Models.Dtos
{
    public class ReservationOnlineDto : ReservationDto
    {
        public string IdWareHouse { get; set; }
        public string IdOnlineSale { get; set; }
    }
}