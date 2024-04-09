using PharMedTOGO.Infrastrucure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace PharMedTOGO.Core.Models
{
    public class MedicineDetailsServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public bool RequiresPrescription { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [EnumDataType(typeof(MedicineCategory))]
        public MedicineCategory Category { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}
