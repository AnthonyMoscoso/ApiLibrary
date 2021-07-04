using Core.Models.Abstracts;

namespace Models.Dtos
{
    public class OccupationDto : IEntity
    {
        public string IdOccupation { get; set; }
        public string OcupationName { get; set; }
        public string OcupationDescription { get; set; }
        public double Salary { get; set; }
        public double PayNormalHours { get; set; }
        public double PayExtraHours { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string _Id { get => IdOccupation; set => IdOccupation = value; }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return IdOccupation.GetHashCode();
        }
    }
}