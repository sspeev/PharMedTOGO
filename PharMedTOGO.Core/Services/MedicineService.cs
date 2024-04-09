using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Enumerations;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Infrastrucure.Data.Enums;
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

        public async Task<AllMedicinesQueryModel> AllAsync(string? serachTerm = null, MedicineSorting sorting = MedicineSorting.Newest, int currentPage = 1, int medicinesPerPage = 1)
        {
            var medicinesToShow = context.Medicines
                .AsNoTracking();

            if (serachTerm != null)
            {
                string normalizedSearchTerm = serachTerm.ToLower();

                medicinesToShow = medicinesToShow
                    .Where(h => (h.Name.ToLower().Contains(normalizedSearchTerm)) ||
                                (h.Description.ToLower().Contains(normalizedSearchTerm)));
            }

            medicinesToShow = sorting switch
            {
                MedicineSorting.Price => medicinesToShow.OrderBy(m => m.Price),
                MedicineSorting.General => medicinesToShow.OrderByDescending(m => m.Category == MedicineCategory.General),
                MedicineSorting.Cosmetics => medicinesToShow.OrderByDescending(m => m.Category == MedicineCategory.Cosmetics),
                MedicineSorting.Homeophatic => medicinesToShow.OrderByDescending(m => m.Category == MedicineCategory.Homeophatic),
                MedicineSorting.FoodAdditives => medicinesToShow.OrderByDescending(m => m.Category == MedicineCategory.FoodAdditives),
                MedicineSorting.Antibiotics => medicinesToShow.OrderByDescending(m => m.Category == MedicineCategory.Antibiotics),
                _ => medicinesToShow.OrderByDescending(h => h.Id)
            };

            var medicines = await medicinesToShow
                .Skip((currentPage - 1) * medicinesPerPage)
                .Take(medicinesPerPage)
                .Select(h => new MedicineServiceModel()
                {
                    Id = h.Id,
                    Name = h.Name,
                    Category = h.Category,
                    ImageUrl = h.ImageUrl,
                    Description = h.Description,
                    Price = h.Price,
                    RequiresPrescription = h.RequiresPrescription,
                })
                .ToListAsync();

            var totalHouses = medicines.Count();

            return new AllMedicinesQueryModel()
            {
                MedicinesCount = totalHouses,
                Medicines = medicines
            };
        }

        public async Task AttachSaleToMedticine(int medicineId, SaleServiceModel saleModel)
        {
            var medicine = await ExistsByIdAsync(medicineId);
            var sale = new Sale()
            {
                Discount = saleModel.Discount,
                StartDate = saleModel.StartDate,
                EndDate = saleModel.EndDate,
            };
            medicine.Sale = sale;
            medicine.Price = medicine.Price - Math.Round(medicine.Price * (sale.Discount / 100));

            await context.SaveChangesAsync();
        }

        public async Task CreateAsync(MedicineFormModel model)
        {
            var medicine = new Medicine()
            {
                Name = model.Name,
                RequiresPrescription = model.RequiresPrescription,
                ImageUrl = model.ImageUrl,
                Category = model.Category,
                Price = model.Price,
                Description = model.Description
            };

            await context.AddAsync(medicine);
            await context.SaveChangesAsync();
        }

        public async Task<Medicine> ExistsByIdAsync(int id)
        {
            return await context.Medicines
                .FirstOrDefaultAsync(x => x.Id == id) ?? throw new ArgumentException("Unexisting medicine");
        }

        public MedicineDetailsServiceModel MapMedicineToDetails(Medicine medicine)
        {
            return new MedicineDetailsServiceModel()
            {
                Id = medicine.Id,
                Name = medicine.Name,
                Category = medicine.Category,
                Price = medicine.Price,
                Description = medicine.Description,
                RequiresPrescription = medicine.RequiresPrescription,
                ImageUrl = medicine.ImageUrl
            };
        }

        public async Task<MedicineDetailsServiceModel> MedicineDetails(int id)
        {
            return await context.Medicines
                .AsNoTracking()
                .Where(m => m.Id == id)
                .Select(m => new MedicineDetailsServiceModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                    ImageUrl = m.ImageUrl,
                    Category = m.Category,
                    Price = m.Price,
                    Description = m.Description
                })
                .FirstAsync();
        }


    }
}
