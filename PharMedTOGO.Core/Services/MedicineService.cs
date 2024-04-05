using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Infrastrucure.Data;

namespace PharMedTOGO.Core.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly PharMedDbContext context;

        public MedicineService(PharMedDbContext _context)
        {
            context = _context;
        }

        public async Task<bool> ExistsByIdAsync(int id)
        {
            return await context.Medicines.AsNoTracking().AnyAsync(m => m.Id == id);
        }
    }
}
