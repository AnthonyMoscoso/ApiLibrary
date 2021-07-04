using Core.Models.Abstracts;
using System.Collections.Generic;

namespace Models.Dtos
{
    public class StoreDto : IEntity
    {
        public string IdStore { get; set; }
        public string IdDirection { get; set; }
        public string StoreName { get; set; }
        public string StoreDescription { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }

        #region Connections 
        public DirectionDto Direction { get; set; }
        
        public List<ReceptionDto> Reception { get; set; }
      
         public List<EmployeeDto> Employee { get; set; }
        public string _Id { get => IdStore; set => IdStore = value; }


        #endregion
    }
}