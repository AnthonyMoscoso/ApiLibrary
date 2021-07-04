using Core.Models.Abstracts;
using System.Collections.Generic;

namespace Models.Dtos
{
    public class ReceptionDto : IEntity
    {
        public string IdReception { get; set; }
        public string IdEmployee { get; set; }
        public string IdStore { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }

        public virtual List<ReceptionLineDto> ReceptionLine { get; set; }
        public string _Id { get => IdReception; set => IdReception = value; }
    }
}