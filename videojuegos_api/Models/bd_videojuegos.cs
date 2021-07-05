using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace videojuegos_api.Models
{
    public partial class bd_videojuegos : DbContext
    {
        public bd_videojuegos()
            : base("name=bd_videojuegos")
        {
        }

        public virtual DbSet<consola> consolas { get; set; }
        public virtual DbSet<juego> juegos { get; set; }
        public virtual DbSet<mando> mandos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<consola>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<consola>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<juego>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<juego>()
                .Property(e => e.plataforma)
                .IsUnicode(false);

            modelBuilder.Entity<mando>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<mando>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<mando>()
                .Property(e => e.compatibilidad)
                .IsUnicode(false);
        }
    }
}
