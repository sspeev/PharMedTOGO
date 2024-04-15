using PharMedTOGO.Infrastrucure.Data.Enums;

namespace PharMedTOGO.Core.Models
{
    public class PrescriptionServiceModel
    {
        public int Id { get; set; }

        public PrescriptionState PrescriptionState { get; set; }

        public bool IsValid { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ExpireDate { get; set; }

        public string Description { get; set; } = string.Empty;

        public string PatientId { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string EGN { get; set; } = string.Empty;
    }
}
