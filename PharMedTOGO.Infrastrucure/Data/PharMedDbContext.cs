using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Infrastrucure.Data.Configuration;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Infrastrucure.Data
{
    public class PharMedDbContext(DbContextOptions<PharMedDbContext> options, bool seed = true) 
        : IdentityDbContext<Patient, IdentityRole<string>, string>(options)
    {
        public DbSet<Medicine> Medicines { get; set; } = null!;

        public DbSet<Prescription> Prescriptions { get; set; } = null!;

        public DbSet<Sale> Sales { get; set; } = null!;

        public DbSet<Cart> Carts { get; set; } = null!;

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MedicineEntityConfiguration());
            builder.ApplyConfiguration(new PatientEntityConfiguration());
            builder.ApplyConfiguration(new PrescriptionEntityConfiguration());
            builder.ApplyConfiguration(new SaleEntityConfiguration());
            builder.ApplyConfiguration(new CartEntityConfiguration());
            if (seed)
            {
                builder.ApplyConfiguration(new SaleSeedConfiguration());
                builder.ApplyConfiguration(new MedicineSeedConfiguration());
                builder.ApplyConfiguration(new PatientSeedConfiguration());
                builder.ApplyConfiguration(new PrescriptionSeedConfiguration());
                
                builder.ApplyConfiguration(new RoleSeedConfiguration());
                builder.ApplyConfiguration(new UsersRolesSeedConfiguration());
            }
            base.OnModelCreating(builder);
        }
    }
}
