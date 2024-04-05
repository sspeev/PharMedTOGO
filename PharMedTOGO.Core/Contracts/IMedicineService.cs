namespace PharMedTOGO.Core.Contracts
{
    public interface IMedicineService
    {
        Task<bool> ExistsByIdAsync(int id);
    }
}
