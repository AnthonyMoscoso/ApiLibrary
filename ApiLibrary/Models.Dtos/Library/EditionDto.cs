namespace Models.Dtos
{
    public class EditionDto
    {
        public string IdEdition { get; set; }
        public string EditionName { get; set; }
        public string EditionDescription { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    }
}