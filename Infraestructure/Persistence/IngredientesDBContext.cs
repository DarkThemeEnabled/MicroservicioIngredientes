using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence
{
    public class IngredientesDBContext : DbContext
    {
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<TipoIngrediente> TiposIngrediente { get; set; }
        public DbSet<TipoMedida> TiposMedida { get; set; }

        public IngredientesDBContext(DbContextOptions<IngredientesDBContext> options) : base(options) { }

        public IngredientesDBContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=MicroservicioIngrediente;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingrediente>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
                entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired();
                entity.
                HasOne<TipoIngrediente>(e => e.TipoIngrediente)
                .WithMany(ti => ti.Ingredientes)
                .HasForeignKey(e => e.TipoIngredienteID)
                .IsRequired();
                entity.
                HasOne<TipoMedida>(e => e.TipoMedida)
                .WithMany(tm => tm.Ingredientes)
                .HasForeignKey(e => e.TipoMedidaID)
                .IsRequired();
            });

            modelBuilder.Entity<TipoIngrediente>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                 .ValueGeneratedOnAdd();
                entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired();
            });

            modelBuilder.Entity<TipoMedida>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                 .ValueGeneratedOnAdd();
                entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired();
            });            
        }


    }
}
