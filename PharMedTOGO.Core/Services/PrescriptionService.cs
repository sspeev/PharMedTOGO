using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Core.Services
{
    public class PrescriptionService : IPrescriptionService
    {
        private readonly PharMedDbContext context;
        private readonly IAdminService adminService;

        public PrescriptionService(PharMedDbContext _context, 
            IAdminService _adminService)
        {
            context = _context;
            adminService = _adminService;

        }

        public async Task<PrescriptionServiceModel> DetailsAsync(int id)
        {
            var prescription = await FindByIdAsync(id);

            return new PrescriptionServiceModel()
            {
                Id = prescription.Id,
                CreatedOn = prescription.CreatedOn,
                ExpireDate = prescription.ExpireDate,
                Description = prescription.Description,
                IsValid = prescription.IsValid,
                PatientId = prescription.PatientId
            };
        }

        public async Task<bool> ExistsByIdAsync(int id)
        {
            if (await context.Prescriptions.FirstOrDefaultAsync(p => p.Id == id) == null)
            {
                return false;
            }
            return true;
        }

        public async Task<Prescription> FindByIdAsync(int id)
        {
            if (await ExistsByIdAsync(id))
            {
                return await context.Prescriptions.FirstOrDefaultAsync(p => p.Id == id);
            }
            throw new ArgumentException("Unexisting prescription");
        }

        public async Task ValidatePrescription(int id, string userId)
        {
            var prescription = await FindByIdAsync(id);
            prescription.IsReviewd = true;
        }
    }
}
