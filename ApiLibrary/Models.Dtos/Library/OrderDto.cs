using Core.Models.Abstracts;
using System.Collections.Generic;

namespace Models.Dtos
{
    public class OrderDto : IEntity
    {
        public string IdOrder { get; set; }
        public string IdStore { get; set; }
        public string IdEmployee { get; set; }
        public string IdWareHouse { get; set; }
        public int OrderStatus { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string note { get; set; }
        public List<OrderLineDto> OrderLine { get; set; }
        public string _Id { get => IdOrder; set => IdOrder = value; }
    }
}