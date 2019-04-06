using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class TipodetelefonosMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Tipodetelefonos>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Tipodetelefonos> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tipodetelefonos", "dbo");

            // key
            builder.HasKey(t => t.Idtipodetelefono);

            // properties
            builder.Property(t => t.Idtipodetelefono)
                .IsRequired()
                .HasColumnName("idtipodetelefono")
                .HasColumnType("int");

            builder.Property(t => t.Tipodetelefono)
                .IsRequired()
                .HasColumnName("tipodetelefono")
                .HasColumnType("nchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

    }
}
