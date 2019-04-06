using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class CondicionesMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Condiciones>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Condiciones> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("condiciones", "dbo");

            // key
            builder.HasKey(t => t.Idcondicion);

            // properties
            builder.Property(t => t.Idcondicion)
                .IsRequired()
                .HasColumnName("idcondicion")
                .HasColumnType("int");

            builder.Property(t => t.Condicion)
                .IsRequired()
                .HasColumnName("condicion")
                .HasColumnType("nchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Esprofesor)
                .IsRequired()
                .HasColumnName("esprofesor")
                .HasColumnType("bit");

            // relationships
            #endregion
        }

    }
}
