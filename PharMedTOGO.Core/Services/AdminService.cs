using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Core.Contracts;
using PharMedTOGO.Core.Models;
using PharMedTOGO.Infrastrucure.Data;
using PharMedTOGO.Infrastrucure.Data.Enums;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Core.Services;

public class AdminService(
    PharMedDbContext _context,
    IPrescriptionService _prescriptionService) : IAdminService
{
    public async Task<IEnumerable<PatientServiceModel>> AllUsersAsync()
    {
        var users = await _context.Users.AsNoTracking()
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
        var adminRoleId = await _context.Roles.FirstAsync(r => r.Name == AdminConstant);

        return await _context.UserRoles
            .AnyAsync(ur => ur.UserId == userId && ur.RoleId == adminRoleId.Id);
    }

    public async Task MakeAdminByIdAsync(string userId)
    {
        IdentityRole<string> adminRoleId = await _context.Roles.FirstAsync(r => r.Name == AdminConstant);
        await _context.UserRoles.AddAsync(new IdentityUserRole<string>()
        {
            UserId = userId,
            RoleId = adminRoleId.Id
        });

        await _context.SaveChangesAsync();
    }

    public async Task<bool> ExistsByIdAsync(string userId)
        => await _context.Users.AnyAsync(u => u.Id == userId);

    public async Task<PatientServiceModel> FindAdminById(string userId)
    {
        if (await ExistsAdminByUserIdAsync(userId))
        {
            var admin = await _context.Users.FirstAsync(u => u.Id == userId);
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
        var user = await _context.Users
            .FirstOrDefaultAsync(p => p.Id == userId);

        return user?.PrescriptionId != null ? user.PrescriptionId.Value : 0;
    }

    public async Task Validate(bool valid, int id)
    {
        var prescription = await _prescriptionService.FindByIdAsync(id);

        if (valid)
        {
            prescription.IsValid = true;
        }
        else prescription.IsValid = false;

        prescription.PrescriptionState = PrescriptionState.Finished;

        await _context.SaveChangesAsync();
    }

    public async Task<bool> ExistsUserByIdAsync(string userId)
    {
        return await _context.Users
            .AnyAsync(u => u.Id == userId);
    }

    public async Task<PatientServiceModel> FindUserById(string userId)
    {
        if (await ExistsUserByIdAsync(userId))
        {
            var user = await _context.Users.FirstAsync(u => u.Id == userId);
            if (user.PrescriptionId == null)
            {
                user.PrescriptionId = 0;
            }
            return new PatientServiceModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                EGN = user.EGN,
                Email = user.Email,
                PrescriptionId = user.PrescriptionId.Value
            };
        }
        throw new ArgumentException("Unexisting user");
    }
}