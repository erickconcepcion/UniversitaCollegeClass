using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class EstudiantesExtracurricularesMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.EstudiantesExtracurriculares>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.EstudiantesExtracurriculares> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("estudiantes_extracurriculares", "dbo");

            // key
            builder.HasKey(t => t.Idextracurricular);

            // properties
            builder.Property(t => t.Idextracurricular)
                .IsRequired()
                .HasColumnName("idextracurricular")
                .HasColumnType("int");

            builder.Property(t => t.Matricula)
                .IsRequired()
                .HasColumnName("matricula")
                .HasColumnType("char(8)")
                .HasMaxLength(8);

            builder.Property(t => t.Idtipoactividad)
                .IsRequired()
                .HasColumnName("idtipoactividad")
                .HasColumnType("int");

            builder.Property(t => t.Actividad)
                .IsRequired()
                .HasColumnName("actividad")
                .HasColumnType("int");

            builder.Property(t => t.Fecha)
                .IsRequired()
                .HasColumnName("fecha")
                .HasColumnType("date");

            builder.Property(t => t.Horas)
                .IsRequired()
                .HasColumnName("horas")
                .HasColumnType("float");

            builder.Property(t => t.Idestado)
                .IsRequired()
                .HasColumnName("idestado")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Estados)
                .WithMany(t => t.EstudiantesExtracurriculares)
                .HasForeignKey(d => d.Idestado)
                .HasConstraintName("FK_estudiantes_extracurriculares_estados");

            builder.HasOne(t => t.Estudiantes)
                .WithMany(t => t.EstudiantesExtracurriculares)
                .HasForeignKey(d => d.Matricula)
                .HasConstraintName("FK_estudiantes_extracurriculares_estudiantes");

            builder.HasOne(t => t.Tipodeactividades)
                .WithMany(t => t.EstudiantesExtracurriculares)
                .HasForeignKey(d => d.Idtipoactividad)
                .HasConstraintName("FK_estudiantes_extracurriculares_tipodeactividades");

            #endregion
        }

    }
}
