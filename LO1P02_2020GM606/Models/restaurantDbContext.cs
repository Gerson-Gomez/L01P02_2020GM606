using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace LO1P02_2020GM606.Models
{
    public class restaurantDbContext : DbContext
    {
        public restaurantDbContext(DbContextOptions<restaurantDbContext> options) : base(options)
        {

        }
        public DbSet<pedidos> pedidos { get; set; }
        public DbSet<motoristas> motoristas { get; set; }
        public DbSet<platos> platos { get; set; }
        public DbSet<clientes> clientes { get; set; }

    }
}
