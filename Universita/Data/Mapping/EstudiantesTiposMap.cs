using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class EstudiantesTiposMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.EstudiantesTipos>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.EstudiantesTipos> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("estudiantes_tipos", "dbo");

            // key
            builder.HasKey(t => t.Idtipo);

            // properties
            builder.Property(t => t.Idtipo)
                .IsRequired()
                .HasColumnName("idtipo")
                .HasColumnType("int");

            builder.Property(t => t.Tipo)
                .IsRequired()
                .HasColumnName("tipo")
                .HasColumnType("nchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

    }
}
