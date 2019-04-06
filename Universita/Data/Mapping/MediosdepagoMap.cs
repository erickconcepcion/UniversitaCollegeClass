using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class MediosdepagoMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Mediosdepago>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Mediosdepago> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("mediosdepago", "dbo");

            // key
            builder.HasKey(t => t.Idmediodepago);

            // properties
            builder.Property(t => t.Idmediodepago)
                .IsRequired()
                .HasColumnName("idmediodepago")
                .HasColumnType("int");

            builder.Property(t => t.Mediodepago)
                .IsRequired()
                .HasColumnName("mediodepago")
                .HasColumnType("nchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

    }
}
