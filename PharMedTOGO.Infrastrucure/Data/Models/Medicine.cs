using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Infrastrucure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static PharMedTOGO.Infrastrucure.Constants.DataConstants;

namespace PharMedTOGO.Infrastrucure.Data.Models
{
    [Comment("Medicine Entity")]
    public class Medicine
    {
        [Key]
        [Comment("The identifier of the medicine")]
        public int Id { get; set; }

        [Required]
        [MaxLength(MedicineNameMaxLength)]
        [Comment("The name of the medicine")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("The url of the medicine's image")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Comment("Boolean property which shows if the current medicine requires prescription")]
        public bool RequiresPrescription { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Comment("The price of the medicine")]
        public decimal Price { get; set; }

        [Required]
        [EnumDataType(typeof(MedicineCategory))]
        public MedicineCategory Category { get; set; }

        [Required]
        [Comment("A byte array for pdf file where is stored the description of the medicine")]
        public string Description { get; set; } = string.Empty;

        public int? SaleId { get; set; }

        [ForeignKey(nameof(SaleId))]
        public Sale? Sale { get; set; }
    }
}
