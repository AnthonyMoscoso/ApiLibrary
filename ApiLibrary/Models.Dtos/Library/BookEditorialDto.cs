namespace Models.Dtos
{
    public class BookEditorialDto
    {
        public string IdBookEditorial { get; set; }
        public string IdBook { get; set; }
        public string IdEditorial { get; set; }
        public double PurchasePrice { get; set; }
        public bool IsDiscontinued { get; set; }
    }
}