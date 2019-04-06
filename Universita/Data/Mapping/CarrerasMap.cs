using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class CarrerasMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Carreras>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Carreras> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("carreras", "dbo");

            // key
            builder.HasKey(t => t.Idcarrera);

            // properties
            builder.Property(t => t.Idcarrera)
                .IsRequired()
                .HasColumnName("idcarrera")
                .HasColumnType("int");

            builder.Property(t => t.Idestado)
                .IsRequired()
                .HasColumnName("idestado")
                .HasColumnType("int");

            builder.Property(t => t.Carrera)
                .IsRequired()
                .HasColumnName("carrera")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            // relationships
            #endregion
        }

    }
}
