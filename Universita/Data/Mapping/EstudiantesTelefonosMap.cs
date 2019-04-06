using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class EstudiantesTelefonosMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.EstudiantesTelefonos>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.EstudiantesTelefonos> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("estudiantes_telefonos", "dbo");

            // key
            builder.HasKey(t => t.Idtelefono);

            // properties
            builder.Property(t => t.Idtelefono)
                .IsRequired()
                .HasColumnName("idtelefono")
                .HasColumnType("int");

            builder.Property(t => t.Matricula)
                .IsRequired()
                .HasColumnName("matricula")
                .HasColumnType("char(8)")
                .HasMaxLength(8);

            builder.Property(t => t.Codigodearea)
                .IsRequired()
                .HasColumnName("codigodearea")
                .HasColumnType("int");

            builder.Property(t => t.Codigodepais)
                .IsRequired()
                .HasColumnName("codigodepais")
                .HasColumnType("int");

            builder.Property(t => t.Telefono)
                .IsRequired()
                .HasColumnName("telefono")
                .HasColumnType("int");

            builder.Property(t => t.Idtipodetelefono)
                .IsRequired()
                .HasColumnName("idtipodetelefono")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Estudiantes)
                .WithMany(t => t.EstudiantesTelefonos)
                .HasForeignKey(d => d.Matricula)
                .HasConstraintName("FK_estudiantes_telefonos_estudiantes");

            builder.HasOne(t => t.Tipodetelefonos)
                .WithMany(t => t.EstudiantesTelefonos)
                .HasForeignKey(d => d.Idtipodetelefono)
                .HasConstraintName("FK_estudiantes_telefonos_tipodetelefonos");

            #endregion
        }

    }
}
