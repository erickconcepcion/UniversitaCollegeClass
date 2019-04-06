using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class CiudadesMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Ciudades>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Ciudades> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ciudades", "dbo");

            // key
            builder.HasKey(t => t.Idciudad);

            // properties
            builder.Property(t => t.Idciudad)
                .IsRequired()
                .HasColumnName("idciudad")
                .HasColumnType("int");

            builder.Property(t => t.Ciudad)
                .IsRequired()
                .HasColumnName("ciudad")
                .HasColumnType("nchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

    }
}
