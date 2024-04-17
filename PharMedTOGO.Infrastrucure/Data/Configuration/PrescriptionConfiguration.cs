using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Data.Models;
using PharMedTOGO.Infrastrucure.Seed;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class PrescriptionConfiguration : IEntityTypeConfiguration<Prescription>
    {
        private bool seed;

        public PrescriptionConfiguration(bool _seed)
        {
            seed = _seed;
        }

        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            if (seed)
            {
                var data = new SeedData();

                builder
                    .HasData(
                    data.Prescription1,
                    data.Prescription2
                    );
            }
        }
    }
}
