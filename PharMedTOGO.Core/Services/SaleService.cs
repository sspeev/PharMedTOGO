using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Core.Services
{
    public class SaleService : ISaleService
    {
        private readonly PharMedDbContext context;

        public SaleService(PharMedDbContext _context)
        {
            context = _context;
        }

        public async Task CreateAsync(SaleFormModel model)
        {
            var sale = new Sale() 
            {
                Discount = model.Discount,
                StartDate = model.StartDate,
                EndDate = model.EndDate
            };

            await context.AddAsync(sale);
            await context.SaveChangesAsync();
        }

        public async Task<SaleServiceModel> FindByIdAsync(int id)
        {
            var sale = await context.Sales.FirstOrDefaultAsync(s => s.Id == id);

            return new SaleServiceModel()
            {
                Id = sale.Id,
                Discount = sale.Discount,
                StartDate = sale.StartDate,
                EndDate = sale.EndDate
            };
        }
    }
}
