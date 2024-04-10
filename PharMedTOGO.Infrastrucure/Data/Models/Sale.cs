using Microsoft.EntityFrameworkCore;
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
        [Comment("Decimal value for the sale percentage")]
        public decimal Discount { get; set; }

        [Comment("When the sale starts")]
        public DateTime StartDate { get; set; }

        [Comment("When the sale ends")]
        public DateTime EndDate { get; set; }

        [Comment("Is the sale applied on a medicine")]
        public bool IsApplied { get; set; }

        [Comment("Is the sale ended")]
        public bool IsEnded { get; set; }
    }
}
