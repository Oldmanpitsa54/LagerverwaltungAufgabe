using Lagerverwaltung.Models;
using Microsoft.EntityFrameworkCore;

namespace Lagerverwaltung.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Artikel> Artikels { get; set; }
        public DbSet<Artikelgruppe> Artikelsgruppen { get; set; }
    }
}