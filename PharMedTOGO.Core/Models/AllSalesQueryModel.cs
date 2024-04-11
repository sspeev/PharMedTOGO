namespace PharMedTOGO.Core.Models
{
    public class AllSalesQueryModel
    {
        public int TotalSales { get; set; }

        public IEnumerable<SaleServiceModel> Sales { get; set; }
        = new List<SaleServiceModel>();

        public IEnumerable<MedicineServiceModel> Medicines { get; set; }
        = new List<MedicineServiceModel>();
    }
}
