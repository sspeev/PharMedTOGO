﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Areas.Admin.Models;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Infrastrucure.Data.Enums;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly PharMedDbContext context;
        private readonly IPrescriptionService prescriptionService;

        public AdminService(PharMedDbContext _context,
            IPrescriptionService _prescriptionService)
        {
            context = _context;
            prescriptionService = _prescriptionService;
        }
        public async Task<IEnumerable<PatientServiceModel>> AllUsersAsync()
        {
            var users = await context.Users.AsNoTracking()
                .Select(u => new PatientServiceModel()
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    EGN = u.EGN
                })
                .OrderBy(u => u.FirstName)
                .ToListAsync();

            return users;
        }

        public async Task<bool> ExistsAdminByUserIdAsync(string userId)
        {
            var adminRoleId = await context.Roles.FirstAsync(r => r.Name == AdminConstant);

            return await context.UserRoles
                .AnyAsync(ur => ur.UserId == userId && ur.RoleId == adminRoleId.Id);
        }

        public async Task MakeAdminByIdAsync(string userId)
        {
            IdentityRole<string> adminRoleId = await context.Roles.FirstAsync(r => r.Name == AdminConstant);
            await context.UserRoles.AddAsync(new IdentityUserRole<string>()
            {
                UserId = userId,
                RoleId = adminRoleId.Id
            });

            await context.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
            => await context.Users.AnyAsync(u => u.Id == userId);

        public async Task<PatientServiceModel> FindAdminById(string userId)
        {
            if (await ExistsAdminByUserIdAsync(userId))
            {
                var admin = await context.Users.FirstAsync(u => u.Id == userId);
                return new PatientServiceModel()
                {
                    Id = admin.Id,
                    FirstName = admin.FirstName,
                    LastName = admin.LastName,
                    EGN = admin.EGN
                };
            }
            throw new ArgumentException("Unexisting admin");
        }

        public async Task<int> HasUserPrescription(string userId)
        {
            var prescription = await context.Prescriptions
                .FirstOrDefaultAsync(pr => pr.PatientId == userId);

            if (prescription != null)
            {
                return prescription.Id;
            }
            return 0;
        }

        public async Task Validate(bool valid, int id)
        {
            var prescription = await prescriptionService.FindByIdAsync(id);

            if (valid)
            {
                prescription.IsValid = true;
            }
            else prescription.IsValid = false;

            prescription.PrescriptionState = PrescriptionState.Finished;

            await context.SaveChangesAsync();
        }
    }
}