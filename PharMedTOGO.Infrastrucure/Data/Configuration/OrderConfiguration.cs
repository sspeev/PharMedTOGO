using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Data.Models;
using PharMedTOGO.Infrastrucure.Seed;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            var data = new SeedData();

            builder
                .HasData(
                    data.Order1,
                    data.Order2
                    );
            builder
                .HasMany(o => o.Medicines);
        }
    }
}
