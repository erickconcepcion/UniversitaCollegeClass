using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class EstudiantesDireccionesMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.EstudiantesDirecciones>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.EstudiantesDirecciones> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("estudiantes_direcciones", "dbo");

            // key
            builder.HasKey(t => t.Iddireccion);

            // properties
            builder.Property(t => t.Iddireccion)
                .IsRequired()
                .HasColumnName("iddireccion")
                .HasColumnType("int");

            builder.Property(t => t.Matricula)
                .IsRequired()
                .HasColumnName("matricula")
                .HasColumnType("char(8)")
                .HasMaxLength(8);

            builder.Property(t => t.Idtipodedireccion)
                .IsRequired()
                .HasColumnName("idtipodedireccion")
                .HasColumnType("int");

            builder.Property(t => t.Calle)
                .IsRequired()
                .HasColumnName("calle")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Numero)
                .IsRequired()
                .HasColumnName("numero")
                .HasColumnType("int");

            builder.Property(t => t.Idsector)
                .IsRequired()
                .HasColumnName("idsector")
                .HasColumnType("int");

            builder.Property(t => t.Idciudad)
                .IsRequired()
                .HasColumnName("idciudad")
                .HasColumnType("int");

            builder.Property(t => t.Idpais)
                .IsRequired()
                .HasColumnName("idpais")
                .HasColumnType("int");

            builder.Property(t => t.Codigopostal)
                .IsRequired()
                .HasColumnName("codigopostal")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Ciudades)
                .WithMany(t => t.EstudiantesDirecciones)
                .HasForeignKey(d => d.Idciudad)
                .HasConstraintName("FK_estudiantes_direcciones_ciudades");

            builder.HasOne(t => t.Estudiantes)
                .WithMany(t => t.EstudiantesDirecciones)
                .HasForeignKey(d => d.Matricula)
                .HasConstraintName("FK_estudiantes_direcciones_estudiantes");

            builder.HasOne(t => t.Paises)
                .WithMany(t => t.EstudiantesDirecciones)
                .HasForeignKey(d => d.Idpais)
                .HasConstraintName("FK_estudiantes_direcciones_paises");

            builder.HasOne(t => t.Sectores)
                .WithMany(t => t.EstudiantesDirecciones)
                .HasForeignKey(d => d.Idsector)
                .HasConstraintName("FK_estudiantes_direcciones_sectores");

            builder.HasOne(t => t.Tipodedireccion)
                .WithMany(t => t.EstudiantesDirecciones)
                .HasForeignKey(d => d.Idtipodedireccion)
                .HasConstraintName("FK_estudiantes_direcciones_tipodedireccion");

            #endregion
        }

    }
}
