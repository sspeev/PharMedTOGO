using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Core.Contracts
{
    public interface IPrescriptionService
    {
        Task<PrescriptionServiceModel> DetailsAsync(int id);

        Task<bool> ExistsByIdAsync(int id);

        Task<Prescription> FindByIdAsync(int id);

        Task ValidatePrescription(int id, string userId);
    }
}
