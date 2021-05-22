namespace Models.Dtos
{
    public class StoreSaleDto : SaleDto
    {
        public string IdStore { get; set; }
        public string IdSeller { get; set; }
        
    }
}