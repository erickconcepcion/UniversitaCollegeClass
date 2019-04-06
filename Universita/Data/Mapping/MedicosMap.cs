using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class MedicosMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Medicos>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Medicos> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("medicos", "dbo");

            // key
            builder.HasKey(t => t.Idmedico);

            // properties
            builder.Property(t => t.Idmedico)
                .IsRequired()
                .HasColumnName("idmedico")
                .HasColumnType("int");

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

            builder.Property(t => t.Idtipodemedico)
                .IsRequired()
                .HasColumnName("idtipodemedico")
                .HasColumnType("int");

            builder.Property(t => t.Idcondicion)
                .IsRequired()
                .HasColumnName("idcondicion")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.MedicosTipos)
                .WithMany(t => t.Medicos)
                .HasForeignKey(d => d.Idtipodemedico)
                .HasConstraintName("FK_medicos_medicos_tipos");

            #endregion
        }

    }
}
