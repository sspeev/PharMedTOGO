using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Core.Services;

public class TransactionService(PharMedDbContext _context) : ITransactionService
{
    public async Task AddAsync(TransactionServiceModel model)
    {
        var transaction = new Transaction()
        {
            Email = model.Email,
            Amount = model.Amount,
            SessionIntendId = model.SessionIntendId
        };

        await _context.AddRangeAsync(transaction);
        await _context.SaveChangesAsync();
    }
}
