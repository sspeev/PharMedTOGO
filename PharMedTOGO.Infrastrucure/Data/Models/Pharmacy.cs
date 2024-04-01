using System.ComponentModel.DataAnnotations;
using static PharMedTOGO.Infrastrucure.Constants.DataConstants;

namespace PharMedTOGO.Infrastrucure.Data.Models
{
    public class Pharmacy
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(PharmacyLocationMaxLength)]
        public string Location { get; set; } = string.Empty;

        public IList<Order> Orders { get; set; }
        = new List<Order>();
    }
}
