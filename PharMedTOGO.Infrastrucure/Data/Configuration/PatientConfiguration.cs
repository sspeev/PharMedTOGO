using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
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
