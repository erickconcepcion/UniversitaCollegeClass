using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class EstudiantesCalificacionesMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.EstudiantesCalificaciones>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.EstudiantesCalificaciones> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("estudiantes_calificaciones", "dbo");

            // key
            builder.HasKey(t => t.Idregistro);

            // properties
            builder.Property(t => t.Idregistro)
                .IsRequired()
                .HasColumnName("idregistro")
                .HasColumnType("int");

            builder.Property(t => t.Matricula)
                .IsRequired()
                .HasColumnName("matricula")
                .HasColumnType("char(8)")
                .HasMaxLength(8);

            builder.Property(t => t.Idcarrera)
                .IsRequired()
                .HasColumnName("idcarrera")
                .HasColumnType("int");

            builder.Property(t => t.Idplan)
                .IsRequired()
                .HasColumnName("idplan")
                .HasColumnType("int");

            builder.Property(t => t.Idmateria)
                .IsRequired()
                .HasColumnName("idmateria")
                .HasColumnType("int");

            builder.Property(t => t.Grupo)
                .IsRequired()
                .HasColumnName("grupo")
                .HasColumnType("char(5)")
                .HasMaxLength(5);

            builder.Property(t => t.Cursada)
                .IsRequired()
                .HasColumnName("cursada")
                .HasColumnType("date");

            builder.Property(t => t.Notaparcial1)
                .IsRequired()
                .HasColumnName("notaparcial_1")
                .HasColumnType("float");

            builder.Property(t => t.Notaparcial2)
                .IsRequired()
                .HasColumnName("notaparcial_2")
                .HasColumnType("float");

            builder.Property(t => t.Notafinal)
                .IsRequired()
                .HasColumnName("notafinal")
                .HasColumnType("float");

            builder.Property(t => t.Idprofesor)
                .IsRequired()
                .HasColumnName("idprofesor")
                .HasColumnType("int");

            builder.Property(t => t.Idestado)
                .IsRequired()
                .HasColumnName("idestado")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Estados)
                .WithMany(t => t.EstudiantesCalificaciones)
                .HasForeignKey(d => d.Idestado)
                .HasConstraintName("FK_estudiantes_calificaciones_estados");

            builder.HasOne(t => t.Carreras)
                .WithMany(t => t.EstudiantesCalificaciones)
                .HasForeignKey(d => d.Idcarrera)
                .HasConstraintName("FK_estudiantes_materias_carreras");

            builder.HasOne(t => t.Estudiantes)
                .WithMany(t => t.EstudiantesCalificaciones)
                .HasForeignKey(d => d.Matricula)
                .HasConstraintName("FK_estudiantes_materias_estudiantes");

            builder.HasOne(t => t.Plandeestudios)
                .WithMany(t => t.EstudiantesCalificaciones)
                .HasForeignKey(d => d.Idplan)
                .HasConstraintName("FK_estudiantes_materias_plandeestudios");

            builder.HasOne(t => t.Profesores)
                .WithMany(t => t.EstudiantesCalificaciones)
                .HasForeignKey(d => d.Idprofesor)
                .HasConstraintName("FK_estudiantes_materias_profesores");

            #endregion
        }

    }
}
