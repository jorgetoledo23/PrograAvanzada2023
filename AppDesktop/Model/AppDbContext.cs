using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.Model
{
    public class AppDbContext : DbContext
    {

        public DbSet<Sede> tblSedes { get; set; }
        public DbSet<Model> tblUsuarios { get; set; }
        public DbSet<Carrera> tblCarreras { get; set; }
        public DbSet<Asignatura> tblAsignaturas { get; set; }
        public DbSet<Docente> tblDocentes { get; set; }
        public DbSet<Alumno> tlbAlumnos { get; set; }
        public DbSet<Seccion> tblSeccion { get; set; }
        public DbSet<CarreraSede> tblCarreraSede { get; set; }
        public DbSet<SeccionAlumnos> tblSeccionAlumnos { get; set; }
        public DbSet<CarreraAsignatura> tblCarreraAsignaturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDSistemaInacap2023;");
        }
    }
}
