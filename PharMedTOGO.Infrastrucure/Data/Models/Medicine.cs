using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
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
        [Comment("Boolean property which shows if the current medicine requires prescription")]
        public bool RequiresPrescription { get; set; }

        [Required]
        [Comment("The price of the medicine")]
        public decimal Price { get; set; }

        [Required]
        [Comment("A byte array for pdf file where is stored the description of the medicine")]
        public byte[] Description { get; set; } = null!;
    }
}
