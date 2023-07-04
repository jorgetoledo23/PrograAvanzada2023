using Microsoft.EntityFrameworkCore;

namespace WebInacap.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Sede> tblSedes { get; set; }
        public DbSet<Carrera> tblCarreras { get; set; }
        public DbSet<SedeCarrera> tblSedeCarreras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebInacap2023;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SedeCarrera>().HasKey(e => new {e.SedeId, e.CarreraId});
        }


    }
}
