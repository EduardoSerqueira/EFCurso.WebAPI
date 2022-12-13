using EFCurso.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCurso.WebAPI.Data
{
    public class HeroiContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadeSecreta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=1234;Persist Security Info=True;User ID=sa;Initial Catalog=HeroDB;Data Source=DESKTOP-I7OHO6G");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity => 
            {
                entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
            }); 
        }
    }
}
