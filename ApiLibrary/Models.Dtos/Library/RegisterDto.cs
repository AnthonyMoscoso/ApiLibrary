using Core.Models.Abstracts;
using System.Collections.Generic;

namespace Models.Dtos
{
    public class RegisterDto : IEntity
    {
        public string IdRegister { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public List<RegisterLineDto> RegisterLine { get; set; }
        public string _Id { get => IdRegister; set => IdRegister = value; }
    }
}