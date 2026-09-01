using Microsoft.EntityFrameworkCore;
using PersonelYonetimApi.Models;

namespace PersonelYonetimApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Personel> Personeller { get; set; }
    }
}