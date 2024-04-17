using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Seed;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        private bool seed;

        public RoleConfiguration(bool _seed)
        {
            seed = _seed;
        }
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            if (seed)
            {
                var data = new SeedData();
                builder.HasData(data.Roles);
            }
        }
    }
}
