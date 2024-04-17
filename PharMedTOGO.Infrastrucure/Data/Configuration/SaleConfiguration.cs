using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Data.Models;
using PharMedTOGO.Infrastrucure.Seed;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        private bool seed;

        public SaleConfiguration(bool _seed)
        {
            seed = _seed;
        }
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            if (seed)
            {
                var data = new SeedData();

                builder.HasData(data.Sale1, data.Sale2);
            }

            builder
                .HasMany(s => s.Medicines)
                .WithOne(s => s.Sale);
        }
    }
}
