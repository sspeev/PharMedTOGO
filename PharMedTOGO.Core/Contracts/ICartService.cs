using PharMedTOGO.Core.Models;

namespace PharMedTOGO.Core.Contracts
{
    public interface ICartService
    {
        Task<string> AddToCartAsync(int medicineId, string userId);

        Task<string> RemoveFromCartAsync(int medicineId, string userId);

        Task<AllCartsQueryModel> AllCartProducts(string userId);

        Task<bool> AlreadyAddedToCart(int medicineId, string userId);
    }
}
