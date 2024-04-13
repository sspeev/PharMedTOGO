using System.ComponentModel.DataAnnotations;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Core.Models
{
    public class SaleDeleteModel
    {
        public int Id { get; set; }

        public decimal Discount { get; set; }

        [DisplayFormat(DataFormatString = DateFormat)]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = DateFormat)]
        public DateTime EndDate { get; set; }
    }
}
