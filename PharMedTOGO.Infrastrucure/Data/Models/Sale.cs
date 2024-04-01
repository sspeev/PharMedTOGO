using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharMedTOGO.Infrastrucure.Data.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Discount { get; set; }
    }
}
