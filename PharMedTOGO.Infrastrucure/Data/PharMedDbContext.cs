using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Infrastrucure.Data.Configuration;
using PharMedTOGO.Infrastrucure.Data.Models;
using PharMedTOGO.Infrastrucure.Seed;

namespace PharMedTOGO.Infrastrucure.Data
{
    public class PharMedDbContext : IdentityDbContext<Patient, IdentityRole<string>, string>
    {
        public PharMedDbContext(DbContextOptions<PharMedDbContext> options)
            : base(options)
        {

        }

        public DbSet<Medicine> Medicines { get; set; } = null!;

        public DbSet<Prescription> Prescriptions { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<Sale> Sales { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MedicineConfiguration());
            builder.ApplyConfiguration(new PatientConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UsersRolesConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new PrescriptionConfiguration());
            builder.ApplyConfiguration(new SaleConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
