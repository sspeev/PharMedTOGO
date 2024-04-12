namespace PharMedTOGO.Core.Models
{
    public class AttachMedicineFormModel
    {
        public int SaleId { get; set; }

        public int CurrMedicineId { get; set; }

        public IList<MedicineServiceModel> Medicines { get; set; }
        = new List<MedicineServiceModel>();
    }
}
