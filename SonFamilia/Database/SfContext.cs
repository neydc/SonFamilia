using Microsoft.EntityFrameworkCore;
using SonFamilia.Database.Mapeo;
using SonFamilia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonFamilia.Database
{
    public class SfContext : DbContext
    {
        public SfContext(DbContextOptions<SfContext> options) : base(options) {}

        public SfContext() { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Veterinario> Veterinarios{ get; set; }
        public DbSet<Mascota> Mascotas{ get; set; }
        public DbSet<Post> Posts{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MapUsuario());
            modelBuilder.ApplyConfiguration(new MapMascota());
            modelBuilder.ApplyConfiguration(new VeterinarioMap());
            modelBuilder.ApplyConfiguration(new MapPost());
        }
    }
}
