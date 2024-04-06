using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Data.Models;
using PharMedTOGO.Infrastrucure.Seed;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            var data = new SeedData();

            builder
                .HasData(
                    data.Patient1,
                    data.Patient2
                    );

            builder
                .HasMany(p => p.Prescriptions)
                .WithOne(prescr => prescr.Patient)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Orders)
                .WithOne(o => o.Patient)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
