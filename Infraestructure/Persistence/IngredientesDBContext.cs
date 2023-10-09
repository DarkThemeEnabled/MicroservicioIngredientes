﻿using Domain.Entities;
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

            modelBuilder.Entity<TipoMedida>().HasData
                (
                new TipoMedida
                {
                    Id = 1,
                    Name = "Gramo"
                },

                new TipoMedida
                {
                    Id = 2,
                    Name = "Litro"
                },

                new TipoMedida
                {
                    Id = 3,
                    Name = "Unidad"
                }
                );

            modelBuilder.Entity<TipoIngrediente>().HasData
                (
                new TipoIngrediente
                {
                    Id = 1,
                    Name = "Vegetal"
                },
                new TipoIngrediente
                {
                    Id = 2,
                    Name = "Lacteo"
                },
                new TipoIngrediente
                {
                    Id = 3,
                    Name = "Carne"
                },
                new TipoIngrediente
                {
                    Id = 4,
                    Name = "Especia"
                }
                );
        }


    }
}
