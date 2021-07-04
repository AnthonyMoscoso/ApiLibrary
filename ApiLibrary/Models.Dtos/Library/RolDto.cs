using Core.Models.Abstracts;
using System;

namespace Models.Dtos
{
    public class RolDto : IEntity 
    {
        public string IdRol { get; set; }
        public string RolName { get; set; }
        public string RolDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string _Id { get => IdRol; set => IdRol = value; }
    }
}