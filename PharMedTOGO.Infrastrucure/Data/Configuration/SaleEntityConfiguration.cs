using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class SaleEntityConfiguration : IEntityTypeConfiguration<Sale>
    {
        public SaleEntityConfiguration()
        {
        }
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder
                .HasMany(s => s.Medicines)
                .WithOne(s => s.Sale);
        }
    }
}
