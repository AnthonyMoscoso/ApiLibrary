using BookStoreApi.Models.Library;
using BookStoreApi.Models.Request;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class StoreDto
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
        
    
        #endregion
    }
}