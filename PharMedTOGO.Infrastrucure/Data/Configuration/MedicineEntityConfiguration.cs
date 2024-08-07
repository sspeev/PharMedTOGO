﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharMedTOGO.Infrastrucure.Data.Models;

namespace PharMedTOGO.Infrastrucure.Data.Configuration
{
    public class MedicineEntityConfiguration : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {
            builder
                .HasOne(m => m.Sale)
                .WithMany(s => s.Medicines);
        }
    }
}
