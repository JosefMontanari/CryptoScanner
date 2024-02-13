using CryptoScanner.Data.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace CryptoScanner.Data.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<KryptoDbModel> Kryptos { get; set; }
    }
}
