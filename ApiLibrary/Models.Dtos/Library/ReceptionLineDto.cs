using Core.Models.Abstracts;

namespace Models.Dtos
{
    public class ReceptionLineDto : IEntity
    {
        public string IdReceptionLine { get; set; }
        public string IdReception { get; set; }
        public string IdBook { get; set; }
        public int Quantity { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string _Id { get => IdReceptionLine; set => IdReceptionLine = value; }
    }
}