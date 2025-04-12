using Microsoft.EntityFrameworkCore;
using EnterBridgeApp.Models;

namespace EnterBridgeApp.Data {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<Order> Orders { get; set; }
    }
}
