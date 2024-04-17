using PharMedTOGO.Core.Models;

namespace PharMedTOGO.Core.Contracts
{
    public interface ITransactionService
    {
        Task AddAsync(TransactionServiceModel model);
    }
}
