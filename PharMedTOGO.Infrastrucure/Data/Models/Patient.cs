using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PharMedTOGO.Infrastrucure.Data.Models
{
    [Comment("The patient entity")]
    public class Patient : IdentityUser
    {
        [Required]
        [Comment("The egn of the patient")]
        public int EGN { get; set; }

        [Comment("The address of the patient")]
        public string Address { get; set; } = string.Empty;

        public IList<Prescription> Prescriptions { get; set; }
            = new List<Prescription>();

        public IList<Order> Orders { get; set; }
            = new List<Order>();
    }
}
