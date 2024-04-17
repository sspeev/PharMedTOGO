using System.ComponentModel.DataAnnotations;

namespace PharMedTOGO.Core.Models
{
    public class TransactionServiceModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Required]
        public string SessionIntendId { get; set; } = string.Empty;
    }
}
