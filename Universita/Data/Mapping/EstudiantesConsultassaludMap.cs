using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class EstudiantesConsultassaludMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.EstudiantesConsultassalud>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.EstudiantesConsultassalud> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("estudiantes_consultassalud", "dbo");

            // key
            builder.HasKey(t => t.Idsalud);

            // properties
            builder.Property(t => t.Idsalud)
                .IsRequired()
                .HasColumnName("idsalud")
                .HasColumnType("int");

            builder.Property(t => t.Matricula)
                .IsRequired()
                .HasColumnName("matricula")
                .HasColumnType("char(8)")
                .HasMaxLength(8);

            builder.Property(t => t.Idmedico)
                .IsRequired()
                .HasColumnName("idmedico")
                .HasColumnType("int");

            builder.Property(t => t.Iddiagnostico)
                .IsRequired()
                .HasColumnName("iddiagnostico")
                .HasColumnType("int");

            builder.Property(t => t.Diagnostico)
                .IsRequired()
                .HasColumnName("diagnostico")
                .HasColumnType("ntext");

            builder.Property(t => t.Fecha)
                .IsRequired()
                .HasColumnName("fecha")
                .HasColumnType("date");

            // relationships
            builder.HasOne(t => t.Estudiantes)
                .WithMany(t => t.EstudiantesConsultassaluds)
                .HasForeignKey(d => d.Matricula)
                .HasConstraintName("FK_estudiantes_consultassalud_estudiantes");

            builder.HasOne(t => t.Medicos)
                .WithMany(t => t.EstudiantesConsultassaluds)
                .HasForeignKey(d => d.Idmedico)
                .HasConstraintName("FK_estudiantes_consultassalud_medicos");

            #endregion
        }

    }
}
