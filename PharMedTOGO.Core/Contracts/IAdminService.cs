using PharMedTOGO.Areas.Admin.Models;

namespace PharMedTOGO.Core.Contracts
{
    public interface IAdminService
    {
        Task<bool> ExistsAdminByUserIdAsync(string userId);
        Task MakeAdminByIdAsync(string userId);
        Task<IEnumerable<PatientServiceModel>> AllUsersAsync();
        Task<bool> ExistsByIdAsync(string userId);

        Task<PatientServiceModel> FindAdminById(string userId);
    }
}
