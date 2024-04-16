using System.ComponentModel.DataAnnotations;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Core.Models
{
    public class SaleServiceModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Range(SaleRangePriceMinValue,
            SaleRangeMaxValue,
            ErrorMessage = SaleRangeErrorMessage)]
        public int Discount { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = DateFormat)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = DateFormat)]
        public DateTime EndDate { get; set; }

        public bool IsApplied { get; set; }

        public bool IsEnded { get; set; }

        public IEnumerable<MedicineServiceModel> Medicines { get; set; }
        = new List<MedicineServiceModel>();
    }
}
