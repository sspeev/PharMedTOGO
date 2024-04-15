﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharMedTOGO.Infrastrucure.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PatientId { get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(PatientId))]
        public Patient Patient { get; set; } = null!;

        public IList<Medicine> Medicines { get; set; }
            = new List<Medicine>();
    }
}
