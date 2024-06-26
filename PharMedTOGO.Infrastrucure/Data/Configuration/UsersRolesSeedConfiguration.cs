﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Seed;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class UsersRolesSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public UsersRolesSeedConfiguration()
        {
        }
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            var data = new SeedData();
            builder.HasData(data.UsersRoles);
        }
    }
}
