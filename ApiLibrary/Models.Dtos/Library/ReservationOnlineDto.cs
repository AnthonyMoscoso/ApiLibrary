using Core.Models.Abstracts;
using Models.Dtos;

namespace Models.Models.Dtos
{
    public class ReservationOnlineDto : ReservationDto , IEntity
    {
        public string IdWareHouse { get; set; }
        public string IdOnlineSale { get; set; }
    }
}