using PharMedTOGO.Core.Models;

namespace PharMedTOGO.Core.Contracts
{
    public interface ISaleService
    {
        Task<SaleServiceModel> CreateAsync(SaleFormModel model);

        Task<SaleServiceModel> FindByIdAsync(int id);
    }
}
