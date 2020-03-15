using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PokedexMalHecho.Models
{
    public partial class PokedexMalHechoContext : DbContext
    {
        public PokedexMalHechoContext()
        {
        }

        public PokedexMalHechoContext(DbContextOptions<PokedexMalHechoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pokemones> Pokemones { get; set; }
        public virtual DbSet<Regiones> Regiones { get; set; }
        public virtual DbSet<Tipos> Tipos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-L4MO65IR\\SQLEXPRESS;Database=PokedexMalHecho;persist security info=True;Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Pokemones>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ataque1)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ataque2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ataque3)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ataque4)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.RegionNavigation)
                    .WithMany(p => p.Pokemones)
                    .HasForeignKey(d => d.Region)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rel_Pokemones_Regiones");

                entity.HasOne(d => d.Tipo1Navigation)
                    .WithMany(p => p.PokemonesTipo1Navigation)
                    .HasForeignKey(d => d.Tipo1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rel_Pokemones_Tipo1");

                entity.HasOne(d => d.Tipo2Navigation)
                    .WithMany(p => p.PokemonesTipo2Navigation)
                    .HasForeignKey(d => d.Tipo2)
                    .HasConstraintName("Rel_Pokemones_Tipo2");
            });

            modelBuilder.Entity<Regiones>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CodigoRga)
                    .IsRequired()
                    .HasColumnName("CodigoRGA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tipos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
