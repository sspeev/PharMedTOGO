using PharMedTOGO.Core.Models;

namespace PharMedTOGO.Core.Contracts
{
    public interface ISaleService
    {
        Task CreateAsync(SaleFormModel model);

        Task<SaleServiceModel> FindByIdAsync(int id);
    }
}
