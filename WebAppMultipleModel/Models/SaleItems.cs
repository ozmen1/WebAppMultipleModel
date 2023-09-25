namespace WebAppMultipleModel.Models
{
    public class SaleItems
    {
        public int SaleItemId { get; set; }
        public int SaleId { get; set; }
        public string ItemName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
    }
}
