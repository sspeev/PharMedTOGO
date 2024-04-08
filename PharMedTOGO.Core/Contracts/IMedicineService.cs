using PharMedTOGO.Core.Enumerations;
using PharMedTOGO.Core.Models;

namespace PharMedTOGO.Core.Contracts
{
    public interface IMedicineService
    {
        Task CreateAsync(MedicineFormModel model);

        Task<AllMedicinesQueryModel> AllAsync(string? serachTerm = null,
            MedicineSorting sorting = MedicineSorting.Newest,
            int currentPage = 1,
            int housePerPage = 1);
    }
}
