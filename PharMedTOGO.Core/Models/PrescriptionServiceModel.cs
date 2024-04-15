using System.ComponentModel;

namespace PharMedTOGO.Core.Models
{
    public class PrescriptionServiceModel
    {
        public int Id { get; set; }

        [DisplayName("Is your prescription valid")]
        public bool IsValid { get; set; }

        [DisplayName("Is your prescription reviewd from the admin")]
        public bool IsReviewd { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ExpireDate { get; set; }

        public string Description { get; set; } = string.Empty;

        public string PatientId { get; set; } = string.Empty;
    }
}
