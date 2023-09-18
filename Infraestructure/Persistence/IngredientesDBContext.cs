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
                entity.HasKey(e => e.IngredienteID);
                entity.Property(e => e.IngredienteID)
                .ValueGeneratedOnAdd();
                entity.Property(e => e.Nombre)
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
                entity.HasKey(e => e.TipoIngredienteID);
                entity.Property(e => e.TipoIngredienteID)
                 .ValueGeneratedOnAdd();
                entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            });

            modelBuilder.Entity<TipoMedida>(entity =>
            {
                entity.HasKey(e => e.TipoMedidaID);
                entity.Property(e => e.TipoMedidaID)
                 .ValueGeneratedOnAdd();
                entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            });

            modelBuilder.Entity<TipoMedida>().HasData
                (
                new TipoMedida
                {
                    TipoMedidaID = 1,
                    Nombre = "Gramo"
                },
                
                new TipoMedida
                {
                    TipoMedidaID = 2,
                    Nombre = "Litro"
                },

                new TipoMedida
                {
                    TipoMedidaID = 3,
                    Nombre = "Unidad"
                }
                );

            modelBuilder.Entity<TipoIngrediente>().HasData
                (
                new TipoIngrediente
                {
                    TipoIngredienteID = 1,
                    Nombre = "Vegetal"
                },
                new TipoIngrediente
                {
                    TipoIngredienteID = 2,
                    Nombre = "Lacteo"
                },
                new TipoIngrediente
                {
                    TipoIngredienteID = 3,
                    Nombre = "Carne"
                },
                new TipoIngrediente
                {
                    TipoIngredienteID = 4,
                    Nombre = "Especia"
                }
                );
        }


    }
}
