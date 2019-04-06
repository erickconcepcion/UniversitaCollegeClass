using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class MateriasMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Materias>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Materias> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("materias", "dbo");

            // key
            builder.HasKey(t => t.Idmateria);

            // properties
            builder.Property(t => t.Idmateria)
                .IsRequired()
                .HasColumnName("idmateria")
                .HasColumnType("nchar(6)")
                .HasMaxLength(6);

            builder.Property(t => t.Materia)
                .IsRequired()
                .HasColumnName("materia")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Idcarrera)
                .IsRequired()
                .HasColumnName("idcarrera")
                .HasColumnType("int");

            builder.Property(t => t.Idplan)
                .IsRequired()
                .HasColumnName("idplan")
                .HasColumnType("int");

            builder.Property(t => t.Revisada)
                .IsRequired()
                .HasColumnName("revisada")
                .HasColumnType("date");

            builder.Property(t => t.Idestado)
                .IsRequired()
                .HasColumnName("idestado")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Carreras)
                .WithMany(t => t.Materias)
                .HasForeignKey(d => d.Idcarrera)
                .HasConstraintName("FK_materias_carreras");

            builder.HasOne(t => t.Estados)
                .WithMany(t => t.Materias)
                .HasForeignKey(d => d.Idestado)
                .HasConstraintName("FK_materias_estados");

            builder.HasOne(t => t.Plandeestudios)
                .WithMany(t => t.Materias)
                .HasForeignKey(d => d.Idplan)
                .HasConstraintName("FK_materias_plandeestudios");

            #endregion
        }

    }
}
