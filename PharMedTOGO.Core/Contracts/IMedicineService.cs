using PharMedTOGO.Core.Enumerations;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Core.Contracts
{
    public interface IMedicineService
    {
        Task CreateAsync(MedicineFormModel model);

        AllMedicinesQueryModel AllSorted(string? serachTerm = null,
            MedicineSorting sorting = MedicineSorting.Newest,
            int currentPage = 1,
            int medicinePerPage = 1,
            AllMedicinesQueryModel medicines = null);

        Task<AllMedicinesQueryModel> AllAsync();

        Task<MedicineDetailsServiceModel> MedicineDetails(int id);

        Task<Medicine> FindByIdAsync(int id);

        MedicineServiceModel MapMedicineToService(Medicine medicine);

        Task EditAsync(int medicineId, MedicineFormModel model);
    }
}
