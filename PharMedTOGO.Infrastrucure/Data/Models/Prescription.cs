using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Infrastrucure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharMedTOGO.Infrastrucure.Data.Models
{
    [Comment("The prescription entity")]
    public class Prescription
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Shows the current stated of validating the prescription")]
        [EnumDataType(typeof(PrescriptionState))]
        public PrescriptionState PrescriptionState { get; set; }

        public bool IsValid { get; set; }

        [Comment("The creation date of the prescription")]
        public DateTime CreatedOn { get; set; }

        [Comment("The expire date of the prescription")]
        public DateTime ExpireDate { get; set; }

        [Comment("Prescription's description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Patient's identifier")]
        public string PatientId { get; set; } = string.Empty;

        [Required]
        [Comment("Navigational property ")]
        [ForeignKey(nameof(PatientId))]
        public Patient Patient { get; set; } = null!;
    }
}
