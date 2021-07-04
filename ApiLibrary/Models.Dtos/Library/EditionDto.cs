using Core.Models.Abstracts;

namespace Models.Dtos
{
    public class EditionDto : IEntity 
    {
        public string IdEdition { get; set; }
        public string EditionName { get; set; }
        public string EditionDescription { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string _Id { get => IdEdition; set => IdEdition = value; }
    }
}