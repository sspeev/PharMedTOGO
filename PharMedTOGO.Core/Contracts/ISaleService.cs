using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Core.Contracts
{
    public interface ISaleService
    {
        Task<SaleServiceModel> CreateAsync(SaleFormModel model);

        Task<Sale> FindByIdAsync(int id);

        Task<SaleServiceModel> MapByIdSale(int id);

        Task CheckAllSales(IEnumerable<MedicineServiceModel> medicines);
    }
}
