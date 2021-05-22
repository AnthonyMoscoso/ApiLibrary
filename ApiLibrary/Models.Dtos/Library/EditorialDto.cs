namespace Models.Dtos
{
    public class EditorialDto
    {
        public string IdEditorial { get; set; }
        public string IdDirection { get; set; }
        public string IdEditorialFather { get; set; }
        public string EditorialName { get; set; }
        public string EditorialDescription { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    }
}