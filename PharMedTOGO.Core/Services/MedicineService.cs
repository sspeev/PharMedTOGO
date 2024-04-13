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
        //private readonly ISaleService saleService;

        public MedicineService(
            PharMedDbContext _context//,
                                     //ISaleService _saleService
            )
        {
            context = _context;
            //saleService = _saleService;
        }

        public AllMedicinesQueryModel AllSorted(
            string? searchTerm = null,
            MedicineSorting sorting = MedicineSorting.Newest,
            int currentPage = 1,
            int medicinesPerPage = 1,
            AllMedicinesQueryModel medicinesQuery = null)
        {

            var medicinesToShow = medicinesQuery.Medicines.ToList();

            if (searchTerm != null)
            {
                string normalizedSearchTerm = searchTerm.ToLower();

                medicinesToShow = medicinesToShow
                    .Where(h => (h.Name.ToLower().Contains(normalizedSearchTerm)) ||
                                (h.Description.ToLower().Contains(normalizedSearchTerm))).ToList();
            }

            medicinesToShow = sorting switch
            {
                MedicineSorting.Price => medicinesToShow.OrderBy(m => m.Price).ToList(),
                MedicineSorting.General => medicinesToShow.OrderByDescending(m => m.Category == MedicineCategory.General).ToList(),
                MedicineSorting.Cosmetics => medicinesToShow.OrderByDescending(m => m.Category == MedicineCategory.Cosmetics).ToList(),
                MedicineSorting.Homeophatic => medicinesToShow.OrderByDescending(m => m.Category == MedicineCategory.Homeophatic).ToList(),
                MedicineSorting.FoodAdditives => medicinesToShow.OrderByDescending(m => m.Category == MedicineCategory.FoodAdditives).ToList(),
                MedicineSorting.Antibiotics => medicinesToShow.OrderByDescending(m => m.Category == MedicineCategory.Antibiotics).ToList(),
                _ => medicinesToShow.OrderByDescending(h => h.Id).ToList()
            };

            var medicines = medicinesToShow
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
                    SaleId = h.SaleId,
                })
                .ToList();

            var totalHouses = medicinesToShow.Count();

            return new AllMedicinesQueryModel()
            {
                MedicinesCount = totalHouses,
                Medicines = medicines
            };
        }
        public async Task<AllMedicinesQueryModel> AllAsync()
        {
            var medicines = await context.Medicines
                .AsNoTracking()
                .Select(h => new MedicineServiceModel()
                {
                    Id = h.Id,
                    Name = h.Name,
                    Category = h.Category,
                    ImageUrl = h.ImageUrl,
                    Description = h.Description,
                    Price = h.Price,
                    HasSaleApplied = h.HasSaleApplied,
                    RequiresPrescription = h.RequiresPrescription,
                    SaleId = h.SaleId
                })
                .ToListAsync();

            return new AllMedicinesQueryModel()
            {
                MedicinesCount = medicines.Count,
                Medicines = medicines
            };
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

        public async Task<Medicine> FindByIdAsync(int id)
        {
            return await context.Medicines
                .FirstOrDefaultAsync(x => x.Id == id) ?? throw new ArgumentException("Unexisting medicine");
        }

        public MedicineServiceModel MapMedicineToService(Medicine medicine)
        {
            return new MedicineServiceModel()
            {
                Id = medicine.Id,
                Name = medicine.Name,
                Category = medicine.Category,
                Price = medicine.Price,
                HasSaleApplied = medicine.HasSaleApplied,
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
                    Description = m.Description,
                    RequiresPrescription = m.RequiresPrescription
                })
                .FirstAsync();
        }

        public async Task EditAsync(int medicineId, MedicineFormModel model)
        {
            var medicine = await FindByIdAsync(medicineId);

            medicine.Name = model.Name;
            medicine.Category = model.Category;
            medicine.Price = model.Price;
            medicine.RequiresPrescription = model.RequiresPrescription;
            medicine.Description = model.Description;
            medicine.ImageUrl = model.ImageUrl;

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int medicineId)
        {
            var medicine = await FindByIdAsync(medicineId);

            if (medicine.SaleId != null)
            {
                medicine.Sale = null;
            }

            context.Remove(medicine);
            await context.SaveChangesAsync();
        }
    }
}
