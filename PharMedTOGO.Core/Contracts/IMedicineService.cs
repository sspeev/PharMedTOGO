using PharMedTOGO.Core.Enumerations;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Core.Contracts
{
    public interface IMedicineService
    {
        Task CreateAsync(MedicineFormModel model);

        Task<AllMedicinesQueryModel> AllAsync(string? serachTerm = null,
            MedicineSorting sorting = MedicineSorting.Newest,
            int currentPage = 1,
            int medicinePerPage = 1);

        Task<MedicineDetailsServiceModel> MedicineDetails(int id);

        Task<Medicine> ExistsByIdAsync(int id);

        MedicineDetailsServiceModel MapMedicineToDetails(Medicine medicine);
        Task AttachSaleToMedticine(int medicineId, SaleServiceModel saleModel);

    }
}
