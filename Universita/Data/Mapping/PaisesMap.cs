using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class PaisesMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Paises>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Paises> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("paises", "dbo");

            // key
            builder.HasKey(t => t.Idpais);

            // properties
            builder.Property(t => t.Idpais)
                .IsRequired()
                .HasColumnName("idpais")
                .HasColumnType("int");

            builder.Property(t => t.Pais)
                .IsRequired()
                .HasColumnName("pais")
                .HasColumnType("nchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

    }
}
