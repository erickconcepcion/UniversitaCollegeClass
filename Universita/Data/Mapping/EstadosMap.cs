using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class EstadosMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Estados>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Estados> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("estados", "dbo");

            // key
            builder.HasKey(t => t.Idestado);

            // properties
            builder.Property(t => t.Idestado)
                .IsRequired()
                .HasColumnName("idestado")
                .HasColumnType("int");

            builder.Property(t => t.Estado)
                .IsRequired()
                .HasColumnName("estado")
                .HasColumnType("nchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

    }
}
