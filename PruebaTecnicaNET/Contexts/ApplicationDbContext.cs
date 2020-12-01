using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PruebaTecnicaNET.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PruebaTecnicaNET.Contexts 
{
    class ApplicationDbContext : DbContext
    {
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localDb)\\mssqllocaldb;Initial Catalog=Escuela;Integrated Security=True")
               .EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity => {
                entity.HasIndex(e => e.Dni).IsUnique();
            });

            modelBuilder.Entity<AlumnoCurso>().HasKey(x => new { x.AlumnoId, x.CursoId });

            SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstadoCurso>().HasData(
            new List<EstadoCurso>()
            {
                new EstadoCurso(){Id= 1, Nombre = ""},
                new EstadoCurso(){Id= 2, Nombre = "Activo"},
                new EstadoCurso(){Id= 3, Nombre = "En Curso"},
                new EstadoCurso(){Id = 4,Nombre = "Finalizado"},
            });
        }


        public DbSet<Alumno> Alumnos{ get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<AlumnoCurso> AlumnoCursos { get; set; }
        public DbSet<EstadoCurso> EstadoCursos { get; set; }
    }
}
