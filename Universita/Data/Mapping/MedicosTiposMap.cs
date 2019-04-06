using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class MedicosTiposMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.MedicosTipos>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.MedicosTipos> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("medicos_tipos", "dbo");

            // key
            builder.HasKey(t => t.Idtipodemedico);

            // properties
            builder.Property(t => t.Idtipodemedico)
                .IsRequired()
                .HasColumnName("idtipodemedico")
                .HasColumnType("int");

            builder.Property(t => t.Tipodemedico)
                .IsRequired()
                .HasColumnName("tipodemedico")
                .HasColumnType("nchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

    }
}
