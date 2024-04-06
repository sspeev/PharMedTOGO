using PharMedTOGO.Infrastrucure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static PharMedTOGO.Core.Constants.MessageConstants;
using static PharMedTOGO.Infrastrucure.Constants.DataConstants;

namespace PharMedTOGO.Core.Models
{
    public class MedicineFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(MedicineNameMaxLength,
            MinimumLength = MedicineNameMinLength,
            ErrorMessage = MedicineNameLengthErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Does the medicine requires prescription")]
        public bool RequiresPrescription { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(decimal),
                    MedicinePriceMinValue,
                    MedicinePriceMaxValue,
                    ErrorMessage = MedicinePriceRangeError)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [EnumDataType(typeof(MedicineCategory))]
        public MedicineCategory Category { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Write a short description of the medicine")]
        public string Description { get; set; } = string.Empty;
    }
}
