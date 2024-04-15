﻿using Microsoft.EntityFrameworkCore;
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
        [Comment("Boolean property which shows if the current prescription is valid")]
        public bool IsValid { get; set; }

        [Required]
        [Comment("Boolean property which shows if the current prescription is reviewed from the admin")]
        public bool IsReviewd { get; set; }

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
