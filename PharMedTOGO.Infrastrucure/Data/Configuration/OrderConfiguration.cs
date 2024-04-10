using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .HasOne(o => o.Pharmacy)
                .WithMany(p => p.Orders)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(o => o.Medicines);

            builder
                .HasOne(o => o.Sale);
        }
    }
}
