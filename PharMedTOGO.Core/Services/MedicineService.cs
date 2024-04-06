using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Core.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly PharMedDbContext context;

        public MedicineService(PharMedDbContext _context)
        {
            context = _context;
        }

        public async Task CreateAsync(MedicineFormModel model)
        {
            var medicine = new Medicine()
            {
                Name = model.Name,
                RequiresPrescription = model.RequiresPrescription,
                Category = model.Category,
                Price = model.Price,
                Description = model.Description
            };

            await context.AddAsync(medicine);
            await context.SaveChangesAsync();
        }
    }
}
