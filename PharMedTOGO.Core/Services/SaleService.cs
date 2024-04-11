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

            var medicines = await context.Medicines
                .AsNoTracking()
                .Select(m => new MedicineServiceModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                    Description = m.Description,
                    Category = m.Category,
                    RequiresPrescription = m.RequiresPrescription,
                    ImageUrl = m.ImageUrl,
                    Price = m.Price,
                    //SaleId = m.SaleId,
                })
                .ToListAsync();

            return new AllSalesQueryModel()
            {
                TotalSales = sales.Count,
                Sales = sales,
                Medicines = medicines
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

        public async Task CheckSaleDates(IEnumerable<MedicineServiceModel> medicines)
        {
            foreach (var medicine in medicines)
            {
                if (medicine.SaleId.HasValue)
                {
                    var sale = await FindByIdAsync(medicine.SaleId.Value);
                    var discount = medicine.Price * (medicine.Price / 100);
                    if (sale.StartDate.Date <= DateTime.Now.Date && sale.EndDate.Date >= DateTime.Now.Date)
                    {
                        if (!sale.IsApplied)
                        {
                            medicine.Price = medicine.Price - discount;
                            medicine.Price = medicine.Price - discount;
                            sale.IsApplied = true;
                        }
                    }
                    else if (sale.EndDate < DateTime.Now && sale.IsApplied && !sale.IsEnded)
                    {
                        medicine.Price = medicine.Price + discount;
                        medicine.Price = medicine.Price + discount;
                        sale.IsEnded = true;
                    }
                }
            }
            await context.SaveChangesAsync();
        }

        public async Task AttachMedicine(int saleId, int medicineId)
        {
            var sale = await FindByIdAsync(saleId);
            var medicine = await medicineService.FindByIdAsync(medicineId);

            sale.Medicines.Add(medicine);
            medicine.SaleId = saleId;

            await context.SaveChangesAsync();
        }
    }
}
