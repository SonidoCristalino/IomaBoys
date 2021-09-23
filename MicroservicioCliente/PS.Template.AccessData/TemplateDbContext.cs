using Microsoft.EntityFrameworkCore;
using PS.Template.Domain.Entities;
using PS.Template.Domain.EntitiesConfiguration;

namespace PS.Template.AccessData
{
    public class TemplateDbContext : DbContext
    {

        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
        { }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<HistoriaClinica> HistoriaClinica { get; set; }
        public DbSet<Partido> Partido { get; set; }
        public DbSet<Plan> Plan { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration<HistoriaClinica>(new HistoriaClinicaConfiguration());
            modelBuilder.ApplyConfiguration<Partido>(new PartidoConfiguration());
            modelBuilder.ApplyConfiguration<Plan>(new PlanConfiguration());
        }

    }
}
