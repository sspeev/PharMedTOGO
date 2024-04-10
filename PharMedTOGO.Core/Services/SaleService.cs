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
        private readonly IMedicineService medicineService;

        public SaleService(
            PharMedDbContext _context,
            IMedicineService _medicineService)
        {
            context = _context;
            medicineService = _medicineService;
        }

        public async Task<AllSalesQueryModel> AllAsync()
        {
            var sales = await context.Sales
                .AsNoTracking()
                .Select(s => new SaleServiceModel()
                {
                    Id = s.Id,
                    Discount = s.Discount,
                    StartDate = s.StartDate,
                    EndDate = s.EndDate,
                    IsApplied = s.IsApplied,
                    IsEnded = s.IsEnded,
                })
                .ToListAsync();

            return new AllSalesQueryModel()
            {
                TotalSales = sales.Count,
                Sales = sales
            };

        }

        public async Task<SaleServiceModel> CreateAsync(SaleFormModel model)
        {
            var sale = new Sale() 
            {
                Discount = model.Discount,
                StartDate = model.StartDate,
                EndDate = model.EndDate
            };

            await context.AddAsync(sale);
            await context.SaveChangesAsync();

            return new SaleServiceModel()
            {
                Discount = sale.Discount,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                IsApplied = false,
                IsEnded = false
            };
        }

        public async Task<Sale> FindByIdAsync(int id)
        {
            return await context.Sales.FirstOrDefaultAsync(s => s.Id == id) ?? throw new ArgumentException("Unexisting sale");
        }

        public async Task<SaleServiceModel> MapByIdSale(int id)
        {
            var sale = await FindByIdAsync(id);
            return new SaleServiceModel()
            {
                Id = sale.Id,
                Discount = sale.Discount,
                StartDate = sale.StartDate,
                EndDate = sale.EndDate,
                IsApplied = sale.IsApplied,
                IsEnded = sale.IsEnded
            };
        }

        //public async Task CheckAllSales(IEnumerable<MedicineServiceModel> medicines)
        //{
        //    foreach (var item in medicines)
        //    {
        //        if (item.SaleId.HasValue)
        //        {
        //            var sale = await FindByIdAsync(item.SaleId.Value);
        //            var medicine = await medicineService.FindByIdAsync(item.Id);
        //            var discount = item.Price * (item.Price / 100);
        //            if (sale.StartDate.Date <= DateTime.Now.Date && sale.EndDate.Date >= DateTime.Now.Date)
        //            {
        //                if (!sale.IsApplied)
        //                {
        //                    item.Price = item.Price - discount;
        //                    medicine.Price = medicine.Price - discount;
        //                    sale.IsApplied = true;
        //                }
        //            }
        //            else if (sale.EndDate < DateTime.Now && sale.IsApplied && !sale.IsEnded)
        //            {
        //                item.Price = item.Price + discount;
        //                medicine.Price = medicine.Price - discount;
        //                sale.IsEnded = true;
        //            }
        //        }
        //    }
        //    await context.SaveChangesAsync();
        //}
    }
}
