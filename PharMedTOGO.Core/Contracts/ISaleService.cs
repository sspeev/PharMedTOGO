using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Core.Contracts
{
    public interface ISaleService
    {
        Task<SaleServiceModel> CreateAsync(SaleFormModel model);

        Task<bool> ExistsByIdAsync(int id);

        Task<Sale> FindByIdAsync(int id);

        Task<SaleServiceModel> MapByIdSale(int id);

        Task<AllSalesQueryModel> AllAsync();

        Task AttachMedicine(int saleId, int medicineId);

        Task CheckSaleDates(IEnumerable<MedicineServiceModel> medicinese);

        Task EditAsync(int saleId, SaleFormModel model);

        Task DeleteAsync(int saleId);
    }
}
