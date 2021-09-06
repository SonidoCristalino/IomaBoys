using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Template.Domain.Entities;
using System;

namespace PS.Template.Domain.EntitiesConfiguration
{
    public class DocenteConfiguration : IEntityTypeConfiguration<Docente>
    {
        public void Configure(EntityTypeBuilder<Docente> builder)
        {
            builder.HasKey(c => c.DocenteId);
            builder.Property(c => c.DocenteId)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Nombre)
               .HasColumnType("varchar")
               .IsRequired(true)
               .HasMaxLength(50);

            builder.Property(c => c.Apellido)
               .HasColumnType("varchar")
               .IsRequired(true)
               .HasMaxLength(50);

        }
    }
}
