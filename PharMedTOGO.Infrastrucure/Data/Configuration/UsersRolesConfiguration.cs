using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Seed;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class UsersRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        private bool seed;

        public UsersRolesConfiguration(bool _seed)
        {
            seed = _seed;
        }
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            if (seed)
            {
                var data = new SeedData();
                builder.HasData(data.UsersRoles);
            }
        }
    }
}
