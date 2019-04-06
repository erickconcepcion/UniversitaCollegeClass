using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class ProfesoresMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Profesores>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Profesores> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("profesores", "dbo");

            // key
            builder.HasKey(t => t.Idprofesor);

            // properties
            builder.Property(t => t.Idprofesor)
                .IsRequired()
                .HasColumnName("idprofesor")
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

            builder.Property(t => t.Idtipodeprofesor)
                .IsRequired()
                .HasColumnName("idtipodeprofesor")
                .HasColumnType("int");

            builder.Property(t => t.Idcondicion)
                .IsRequired()
                .HasColumnName("idcondicion")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Condiciones)
                .WithMany(t => t.Profesores)
                .HasForeignKey(d => d.Idcondicion)
                .HasConstraintName("FK_profesores_condiciones");

            builder.HasOne(t => t.ProfesoresTipos)
                .WithMany(t => t.Profesores)
                .HasForeignKey(d => d.Idtipodeprofesor)
                .HasConstraintName("FK_profesores_profesores_tipos");

            #endregion
        }

    }
}
