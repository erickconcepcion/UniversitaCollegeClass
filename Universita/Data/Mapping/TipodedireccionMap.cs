using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class TipodedireccionMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.Tipodedireccion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.Tipodedireccion> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tipodedireccion", "dbo");

            // key
            builder.HasKey(t => t.Idtipodedireccion);

            // properties
            builder.Property(t => t.Idtipodedireccion)
                .IsRequired()
                .HasColumnName("idtipodedireccion")
                .HasColumnType("int");

            builder.Property(t => t.TipodedireccionMember)
                .IsRequired()
                .HasColumnName("tipodedireccion")
                .HasColumnType("nchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

    }
}
