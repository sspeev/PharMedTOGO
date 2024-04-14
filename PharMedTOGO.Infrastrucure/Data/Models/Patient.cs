using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static PharMedTOGO.Infrastrucure.Constants.DataConstants;

namespace PharMedTOGO.Infrastrucure.Data.Models
{
    [Index(nameof(EGN), IsUnique = true)]
    [Comment("The patient entity")]
    public class Patient : IdentityUser
    {
        [Required]
        [MaxLength(PatientFirstNameMaxLength)]
        [Comment("The patient's first name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(PatientLastNameMaxLength)]
        [Comment("The patient's last name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Comment("The egn of the patient")]
        public string EGN { get; set; } = string.Empty;

        [Comment("The address of the patient")]
        public string Address { get; set; } = string.Empty;

        //[Required]
        //[Comment("The user's identifier")]
        //public string UserId { get; set; } = string.Empty;

        //[ForeignKey(nameof(UserId))]
        //public IdentityUser User { get; set; } = null!;

        public IList<Prescription> Prescriptions { get; set; }
            = new List<Prescription>();

        public IList<Order> Orders { get; set; }
            = new List<Order>();
    }
}
