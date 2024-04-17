using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Data.Models;
using PharMedTOGO.Infrastrucure.Seed;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        private bool seed;

        public PatientConfiguration(bool _seed)
        {
            seed = _seed;
        }

        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            if (seed)
            {
                var data = new SeedData();

                builder
                    .HasData(
                        data.Patient1,
                        data.Patient2
                        );
            }

            builder
                .HasOne(pat => pat.Prescription)
                .WithOne(pre => pre.Patient)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
