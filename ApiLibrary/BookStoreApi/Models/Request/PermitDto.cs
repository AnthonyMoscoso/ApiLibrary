using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Request
{
    public class PermitDto
    {
        public string IdPermit { get; set; }
        public string PermitName { get; set; }
        public string PermitDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                PermitDto p = (PermitDto)obj;
                return (IdPermit == p.IdPermit);
            }
        }
        public override int GetHashCode()
        {
            return IdPermit.GetHashCode();
        }
    }
}