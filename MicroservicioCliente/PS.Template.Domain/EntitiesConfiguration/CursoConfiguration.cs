using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Template.Domain.Entities;
using System;

namespace PS.Template.Domain.EntitiesConfiguration
{
    public class CursoConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {

            builder.HasKey(c => c.CursoId);
            builder.Property(c => c.CursoId)
            .ValueGeneratedOnAdd();

            builder.Property(c => c.NombreCurso)
               .HasColumnType("varchar")
               .IsRequired(true)
               .HasMaxLength(50);

            builder.Property(c => c.DocenteId)
                .IsRequired(true);
           
        }

    }
}
