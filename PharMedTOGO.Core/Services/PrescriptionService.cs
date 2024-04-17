using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Infrastrucure.Data.Enums;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Core.Services
{
    public class PrescriptionService : IPrescriptionService
    {
        private readonly PharMedDbContext context;

        public PrescriptionService(PharMedDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<PrescriptionServiceModel>> AllAsync()
        {
            return await context.Prescriptions
                .AsNoTracking()
                .Select(pr => new PrescriptionServiceModel()
                {
                    Id = pr.Id,
                    CreatedOn = pr.CreatedOn,
                    Description = pr.Description,
                    ExpireDate = pr.ExpireDate,
                    PrescriptionState = pr.PrescriptionState,
                    IsValid = pr.IsValid,
                    PatientId = pr.PatientId
                })
                .ToListAsync();
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
                PrescriptionState = prescription.PrescriptionState,
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

        public async Task ValidatePrescriptionAsync(int id)
        {
            var prescription = await FindByIdAsync(id);
            if (prescription.PrescriptionState == PrescriptionState.NotReviewed)
            {
                prescription.PrescriptionState = PrescriptionState.Reviewing;
            }
            await context.SaveChangesAsync();
        }
    }
}
