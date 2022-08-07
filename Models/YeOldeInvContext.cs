using Microsoft.EntityFrameworkCore;

namespace YeOldeInvMany.Models
{
  public class YeOldeInvManyContext : DbContext
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }

    public YeOldeInvManyContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}