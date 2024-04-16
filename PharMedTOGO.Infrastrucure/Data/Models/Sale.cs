using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PharMedTOGO.Infrastrucure.Data.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Decimal value for the sale percentage")]
        public int Discount { get; set; }

        [Comment("When the sale starts")]
        public DateTime StartDate { get; set; }

        [Comment("When the sale ends")]
        public DateTime EndDate { get; set; }

        [Comment("Is the sale ended")]
        public bool IsEnded { get; set; }

        public IEnumerable<Medicine> Medicines { get; set; }
        = new List<Medicine>();
    }
}
