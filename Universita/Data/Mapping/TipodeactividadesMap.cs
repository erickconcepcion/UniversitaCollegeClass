using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class TipodeactividadesMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Tipodeactividades>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Tipodeactividades> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tipodeactividades", "dbo");

            // key
            builder.HasKey(t => t.Idtipoactividad);

            // properties
            builder.Property(t => t.Idtipoactividad)
                .IsRequired()
                .HasColumnName("idtipoactividad")
                .HasColumnType("int");

            builder.Property(t => t.Descripcionactividad)
                .IsRequired()
                .HasColumnName("descripcionactividad")
                .HasColumnType("nchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

    }
}
