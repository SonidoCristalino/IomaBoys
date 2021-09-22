using Microsoft.EntityFrameworkCore;
using PS.Template.Domain.Entities;
using PS.Template.Domain.EntitiesConfiguration;

namespace PS.Template.AccessData
{
    public class TemplateDbContext : DbContext
    {

        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
        { }

        public DbSet<Docente> Docente { get; set; }
        public DbSet<Plan> Curso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Docente>(new DocenteConfiguration());
            modelBuilder.ApplyConfiguration<Plan>(new CursoConfiguration());
        }

    }
}
