namespace WebAppMultipleModel.Models
{
    public class SaleViewModel
    {
        public IEnumerable<SaleDetails> SaleDetailsViewModel { get; set; }
        public IEnumerable<SaleItems> SaleItemsViewModel { get; set; }
    }
}
