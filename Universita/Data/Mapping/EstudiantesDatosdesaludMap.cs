using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class EstudiantesDatosdesaludMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.EstudiantesDatosdesalud>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.EstudiantesDatosdesalud> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("estudiantes_datosdesalud", "dbo");

            // key
            builder.HasKey(t => t.Iddatossalud);

            // properties
            builder.Property(t => t.Iddatossalud)
                .IsRequired()
                .HasColumnName("iddatossalud")
                .HasColumnType("int");

            builder.Property(t => t.Matricula)
                .IsRequired()
                .HasColumnName("matricula")
                .HasColumnType("char(8)")
                .HasMaxLength(8);

            builder.Property(t => t.Encasoemergencia)
                .IsRequired()
                .HasColumnName("encasoemergencia")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Tiposangre)
                .IsRequired()
                .HasColumnName("tiposangre")
                .HasColumnType("char(2)")
                .HasMaxLength(2);

            builder.Property(t => t.Rh)
                .IsRequired()
                .HasColumnName("rh")
                .HasColumnType("char(1)")
                .HasMaxLength(1);

            builder.Property(t => t.Alergias)
                .IsRequired()
                .HasColumnName("alergias")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.Padecimientos)
                .IsRequired()
                .HasColumnName("padecimientos")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.Tratamientos)
                .IsRequired()
                .HasColumnName("tratamientos")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.Nombremedico)
                .IsRequired()
                .HasColumnName("nombremedico")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Telefonomedico)
                .IsRequired()
                .HasColumnName("telefonomedico")
                .HasColumnType("nchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Centromedico)
                .IsRequired()
                .HasColumnName("centromedico")
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150);

            builder.Property(t => t.Telefonocentromedico)
                .IsRequired()
                .HasColumnName("telefonocentromedico")
                .HasColumnType("nchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Extension)
                .IsRequired()
                .HasColumnName("extension")
                .HasColumnType("nchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.Seguromedico)
                .IsRequired()
                .HasColumnName("seguromedico")
                .HasColumnType("nchar(30)")
                .HasMaxLength(30);

            // relationships
            builder.HasOne(t => t.Estudiantes)
                .WithMany(t => t.EstudiantesDatosdesaluds)
                .HasForeignKey(d => d.Matricula)
                .HasConstraintName("FK_estudiantes_datosdesalud_estudiantes");

            #endregion
        }

    }
}
