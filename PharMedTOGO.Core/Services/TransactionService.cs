using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Core.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly PharMedDbContext context;

        public TransactionService(PharMedDbContext _context)
        {
            context = _context;
        }

        public async Task AddAsync(TransactionServiceModel model)
        {
            var transaction = new Transaction()
            {
                Email = model.Email,
                Amount = model.Amount,
                SessionIntendId = model.SessionIntendId
            };

            await context.AddRangeAsync(transaction);
            await context.SaveChangesAsync();
        }
    }
}
