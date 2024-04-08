using PharMedTOGO.Core.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace PharMedTOGO.Core.Models
{
    public class AllMedicinesQueryModel
    {
        public int MedicinesPerPage { get; set; }

        [Display(Name = "search by text")]
        public string SearchTerm { get; init; } = string.Empty;

        public MedicineSorting Sorting { get; init; }

        public int CurrentPage { get; set; } = 1;

        public int MedicinesCount { get; set; }

        public IEnumerable<MedicineServiceModel> Medicines { get; set; }
        = new List<MedicineServiceModel>();
    }
}
