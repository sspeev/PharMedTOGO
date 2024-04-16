using PharMedTOGO.Core.Attributes;
using System.ComponentModel.DataAnnotations;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Core.Models
{
    public class SaleFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [Range(SaleRangePriceMinValue, 
            SaleRangeMaxValue, 
            ErrorMessage = SaleRangeErrorMessage)]
        public int Discount { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = DateFormat)]
        //[DateValid]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = DateFormat)]
        //[DateValid]
        public DateTime EndDate { get; set; }
    }
}
