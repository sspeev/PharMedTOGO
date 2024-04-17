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
                    IsEnded = s.IsEnded
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
                    SaleId = m.SaleId
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
        public async Task<bool> ExistsByIdAsync(int id)
        {
            if (await context.Sales.FirstOrDefaultAsync(s => s.Id == id) == null)
            {
                return false;
            }
            return true;
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
                IsEnded = sale.IsEnded
            };
        }

        public async Task CheckSaleDates(IEnumerable<MedicineServiceModel> medicines)
        {
            foreach (var medicineModel in medicines)
            {
                if (medicineModel.SaleId.HasValue)
                {

                    var medicine = await medicineService.FindByIdAsync(medicineModel.Id);//to apply the changes on the database
                    var sale = await FindByIdAsync(medicineModel.SaleId.Value);// to apply the discount on the medicine

                    var discount = medicineModel.Price * (sale.Discount / 100);
                    if (sale.StartDate.Date <= DateTime.Now.Date && sale.EndDate.Date >= DateTime.Now.Date)
                    {
                        if (!medicine.HasSaleApplied)
                        {
                            medicineModel.Price = medicineModel.Price - discount;
                            medicine.Price = medicine.Price - discount;

                            medicineModel.HasSaleApplied = true;
                            medicine.HasSaleApplied = true;
                        }
                    }
                    else if (sale.EndDate < DateTime.Now && !sale.IsEnded)
                    {
                        medicineModel.Price = medicineModel.Price + discount;
                        medicine.Price = medicine.Price - discount;

                        medicine.Sale = null;

                        medicine.SaleId = null;
                        medicineModel.SaleId = null;

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

            IList<Medicine> saleMedicines = sale.Medicines.ToList();
            saleMedicines.Add(medicine);
            medicine.SaleId = saleId;
            decimal salePrice = decimal.Parse(sale.Discount.ToString());
            var discount = medicine.Price * (salePrice / 100);

            if (sale.StartDate.Date <= DateTime.Now.Date && sale.EndDate.Date >= DateTime.Now.Date)
            {
                if (!medicine.HasSaleApplied)
                {
                    medicine.Price = medicine.Price - discount;

                    medicine.HasSaleApplied = true;
                }
            }
            else if (sale.EndDate < DateTime.Now)
            {
                throw new ArgumentException("You entered old expire date!");
            }

            await context.SaveChangesAsync();
        }

        public async Task EditAsync(int saleId, SaleFormModel model)
        {
            var sale = await FindByIdAsync(saleId);

            sale.Discount = model.Discount;
            sale.StartDate = model.StartDate;
            sale.EndDate = model.EndDate;

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int saleId)
        {
            var sale = await FindByIdAsync(saleId);

            if (sale.Medicines.Any())
            {
                sale.Medicines = null;
            }

            context.Remove(sale);
            await context.SaveChangesAsync();
        }
    }
}
