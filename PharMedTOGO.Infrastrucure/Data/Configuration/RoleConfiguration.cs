using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Seed;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var data = new SeedData();
            builder.HasData(data.Roles);
        }
    }
}
