﻿using PharMedTOGO.Core.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace PharMedTOGO.Core.Models
{
    public class AllMedicinesQueryModel
    {
        public int MedicinesPerPage { get; set; } = 5;

        [Display(Name = "search by text")]
        public string SearchTerm { get; set; } = string.Empty;

        public MedicineSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int MedicinesCount { get; set; }

        public IEnumerable<MedicineServiceModel> Medicines { get; set; }
        = new List<MedicineServiceModel>();
    }
}
