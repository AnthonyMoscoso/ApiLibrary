using Core.Models.Abstracts;
using System;

namespace Models.Dtos
{
    public class GenderDto : IEntity
    {
        #region Atributes
        public string IdGender { get; set; }
        public string GenderName { get; set; }
        public string GenderDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        #endregion

        #region IEntity
        public string _Id { get => IdGender; set => IdGender = value; }
        #endregion

        #region Methods
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
        #endregion
    }
}