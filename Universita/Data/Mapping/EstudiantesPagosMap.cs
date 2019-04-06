using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class EstudiantesPagosMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.EstudiantesPagos>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.EstudiantesPagos> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("estudiantes_pagos", "dbo");

            // key
            builder.HasKey(t => t.Idpago);

            // properties
            builder.Property(t => t.Idpago)
                .IsRequired()
                .HasColumnName("idpago")
                .HasColumnType("int");

            builder.Property(t => t.Matricula)
                .IsRequired()
                .HasColumnName("matricula")
                .HasColumnType("char(8)")
                .HasMaxLength(8);

            builder.Property(t => t.Fecha)
                .IsRequired()
                .HasColumnName("fecha")
                .HasColumnType("date");

            builder.Property(t => t.Monto)
                .IsRequired()
                .HasColumnName("monto")
                .HasColumnType("float");

            builder.Property(t => t.Idtipodepago)
                .IsRequired()
                .HasColumnName("idtipodepago")
                .HasColumnType("int");

            builder.Property(t => t.Idmediodepago)
                .IsRequired()
                .HasColumnName("idmediodepago")
                .HasColumnType("int");

            builder.Property(t => t.Numerodeautorizacion)
                .IsRequired()
                .HasColumnName("numerodeautorizacion")
                .HasColumnType("int");

            builder.Property(t => t.Cuentacontable)
                .IsRequired()
                .HasColumnName("cuentacontable")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Estudiantes)
                .WithMany(t => t.EstudiantesPagos)
                .HasForeignKey(d => d.Matricula)
                .HasConstraintName("FK_estudiantes_pagos_estudiantes");

            builder.HasOne(t => t.Mediosdepago)
                .WithMany(t => t.EstudiantesPagos)
                .HasForeignKey(d => d.Idmediodepago)
                .HasConstraintName("FK_estudiantes_pagos_mediosdepago");

            builder.HasOne(t => t.Tipodepagos)
                .WithMany(t => t.EstudiantesPagos)
                .HasForeignKey(d => d.Idtipodepago)
                .HasConstraintName("FK_estudiantes_pagos_tipodepagos");

            #endregion
        }

    }
}
