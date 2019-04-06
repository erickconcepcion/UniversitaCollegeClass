using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Servuniv.Data.Mapping
{
    public partial class ProfesoresTiposMap
        : IEntityTypeConfiguration<Servuniv.Data.Entities.ProfesoresTipos>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Servuniv.Data.Entities.ProfesoresTipos> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("profesores_tipos", "dbo");

            // key
            builder.HasKey(t => t.Idtipodeprofesor);

            // properties
            builder.Property(t => t.Idtipodeprofesor)
                .IsRequired()
                .HasColumnName("idtipodeprofesor")
                .HasColumnType("int");

            builder.Property(t => t.Tipodeprofesor)
                .IsRequired()
                .HasColumnName("tipodeprofesor")
                .HasColumnType("nchar(20)")
                .HasMaxLength(20);

            // relationships
            #endregion
        }

    }
}
