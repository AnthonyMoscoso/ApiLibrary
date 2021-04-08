using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class GenderDto
    {
        public string IdGender { get; set; }
        public string GenderName { get; set; }
        public string GenderDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }

        public override int GetHashCode()
        {
            return IdGender.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                GenderDto x = (GenderDto)obj;
                return (IdGender == x.IdGender);
            }
        }
        public override string ToString()
        {
            return GenderName;
        }
    }
}