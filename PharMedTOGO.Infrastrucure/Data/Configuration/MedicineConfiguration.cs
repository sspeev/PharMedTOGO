using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Data.Models;
using PharMedTOGO.Infrastrucure.Seed;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class MedicineConfiguration : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {
            var data = new SeedData();

            builder
                .HasData(
                    data.Medicine1,
                    data.Medicine2,
                    data.Medicine3,
                    data.Medicine4,
                    data.Medicine5,
                    data.Medicine6,
                    data.Medicine7
                    );
            builder
                .HasOne(m => m.Sale)
                .WithMany(s => s.Medicines);
        }
    }
}
