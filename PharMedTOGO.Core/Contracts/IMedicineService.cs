using PharMedTOGO.Core.Models;

namespace PharMedTOGO.Core.Contracts
{
    public interface IMedicineService
    {
        Task CreateAsync(MedicineFormModel model);
    }
}
