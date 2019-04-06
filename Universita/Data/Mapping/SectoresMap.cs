using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class SectoresMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Sectores>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Sectores> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("sectores", "dbo");

            // key
            builder.HasKey(t => t.Idsector);

            // properties
            builder.Property(t => t.Idsector)
                .IsRequired()
                .HasColumnName("idsector")
                .HasColumnType("int");

            builder.Property(t => t.Sector)
                .IsRequired()
                .HasColumnName("sector")
                .HasColumnType("nchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

    }
}
