using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class PlandeestudiosMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Plandeestudios>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Plandeestudios> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("plandeestudios", "dbo");

            // key
            builder.HasKey(t => t.Idplan);

            // properties
            builder.Property(t => t.Idplan)
                .IsRequired()
                .HasColumnName("idplan")
                .HasColumnType("int");

            builder.Property(t => t.Idcarrera)
                .IsRequired()
                .HasColumnName("idcarrera")
                .HasColumnType("int");

            builder.Property(t => t.Fecha)
                .IsRequired()
                .HasColumnName("fecha")
                .HasColumnType("date");

            builder.Property(t => t.Idestado)
                .IsRequired()
                .HasColumnName("idestado")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Carreras)
                .WithMany(t => t.Plandeestudios)
                .HasForeignKey(d => d.Idcarrera)
                .HasConstraintName("FK_plandeestudios_carreras");

            #endregion
        }

    }
}
