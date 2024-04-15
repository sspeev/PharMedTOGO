using PharMedTOGO.Areas.Admin.Models;

namespace PharMedTOGO.Core.Contracts
{
    public interface IAdminService
    {
        Task<bool> ExistsAdminByUserIdAsync(string userId);
        Task MakeAdminByIdAsync(string userId);
        Task<IEnumerable<UserServiceModel>> AllUsersAsync();
        //Task DeleteByIdAsync(string userId);
        Task<bool> ExistsByIdAsync(string userId);
    }
}
