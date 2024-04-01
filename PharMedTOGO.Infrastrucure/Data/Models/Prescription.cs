using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static PharMedTOGO.Infrastrucure.Constants.DataConstants;

namespace PharMedTOGO.Infrastrucure.Data.Models
{
    [Comment("The prescription entity")]
    public class Prescription
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DoctorFirstNameMaxLength)]
        [Comment("The doctor's first name")]
        public string DoctorFirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(DoctorLastNameMaxLength)]
        [Comment("The doctor's last name")]
        public string DoctorLastName { get; set; } = string.Empty;

        [Required]
        [Comment("Boolean property which shows if the current prescription is checked from the admin")]
        public bool IsChecked { get; set; }

        [Required]
        [Comment("The creation date of the prescription")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment("Navigational property ")]
        public Patient Patient { get; set; } = null!;

        public IList<Medicine> Medicines { get; set; }
            = new List<Medicine>();
    }
}
