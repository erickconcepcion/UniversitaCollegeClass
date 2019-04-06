using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class EstudiantesMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Estudiantes>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Estudiantes> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("estudiantes", "dbo");

            // key
            builder.HasKey(t => t.Matricula);

            // properties
            builder.Property(t => t.Matricula)
                .IsRequired()
                .HasColumnName("matricula")
                .HasColumnType("char(8)")
                .HasMaxLength(8);

            builder.Property(t => t.Identificacion)
                .IsRequired()
                .HasColumnName("identificacion")
                .HasColumnType("nchar(11)")
                .HasMaxLength(11);

            builder.Property(t => t.Nombres)
                .IsRequired()
                .HasColumnName("nombres")
                .HasColumnType("nvarchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Apellidos)
                .IsRequired()
                .HasColumnName("apellidos")
                .HasColumnType("nchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Nacimiento)
                .IsRequired()
                .HasColumnName("nacimiento")
                .HasColumnType("date");

            builder.Property(t => t.Ingreso)
                .IsRequired()
                .HasColumnName("ingreso")
                .HasColumnType("date");

            builder.Property(t => t.Trabaja)
                .IsRequired()
                .HasColumnName("trabaja")
                .HasColumnType("bit");

            builder.Property(t => t.Idcarrera)
                .IsRequired()
                .HasColumnName("idcarrera")
                .HasColumnType("nchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.Idplan)
                .IsRequired()
                .HasColumnName("idplan")
                .HasColumnType("int");

            builder.Property(t => t.Idtipo)
                .IsRequired()
                .HasColumnName("idtipo")
                .HasColumnType("int");

            builder.Property(t => t.Indice)
                .IsRequired()
                .HasColumnName("indice")
                .HasColumnType("float");

            builder.Property(t => t.Idcondicion)
                .IsRequired()
                .HasColumnName("idcondicion")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Condiciones)
                .WithMany(t => t.Estudiantes)
                .HasForeignKey(d => d.Idcondicion)
                .HasConstraintName("FK_estudiantes_condiciones");

            builder.HasOne(t => t.EstudiantesTipos)
                .WithMany(t => t.Estudiantes)
                .HasForeignKey(d => d.Idtipo)
                .HasConstraintName("FK_estudiantes_estudiantes_tipos");

            builder.HasOne(t => t.Plandeestudios)
                .WithMany(t => t.Estudiantes)
                .HasForeignKey(d => d.Idplan)
                .HasConstraintName("FK_estudiantes_plandeestudios");

            #endregion
        }

    }
}
