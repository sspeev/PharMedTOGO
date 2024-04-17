using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PharMedTOGO.Infrastrucure.Data.Configuration;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Infrastrucure.Data
{
    public class PharMedDbContext : IdentityDbContext<Patient, IdentityRole<string>, string>
    {
        private bool seed;

        public PharMedDbContext(DbContextOptions<PharMedDbContext> options, bool _seed = true)
            : base(options)
        {
            if (!Database.IsRelational())
            {
                Database.EnsureCreated();
            }
            else Database.Migrate();

            seed = _seed;
        }

        public DbSet<Medicine> Medicines { get; set; } = null!;

        public DbSet<Prescription> Prescriptions { get; set; } = null!;

        public DbSet<Sale> Sales { get; set; } = null!;

        public DbSet<Cart> Carts { get; set; } = null!;

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MedicineConfiguration(seed));
            builder.ApplyConfiguration(new PatientConfiguration(seed));
            builder.ApplyConfiguration(new RoleConfiguration(seed));
            builder.ApplyConfiguration(new UsersRolesConfiguration(seed));
            builder.ApplyConfiguration(new PrescriptionConfiguration(seed));
            builder.ApplyConfiguration(new SaleConfiguration(seed));
            builder.ApplyConfiguration(new CartConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
