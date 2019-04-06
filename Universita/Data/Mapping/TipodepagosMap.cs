using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class TipodepagosMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Tipodepagos>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Tipodepagos> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tipodepagos", "dbo");

            // key
            builder.HasKey(t => t.Idtipodepago);

            // properties
            builder.Property(t => t.Idtipodepago)
                .IsRequired()
                .HasColumnName("idtipodepago")
                .HasColumnType("int");

            builder.Property(t => t.Tipodepago)
                .IsRequired()
                .HasColumnName("tipodepago")
                .HasColumnType("nchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

    }
}
