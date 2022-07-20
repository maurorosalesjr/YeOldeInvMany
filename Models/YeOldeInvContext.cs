using Microsoft.EntityFrameworkCore;

namespace YeOldeInv.Models
{
  public class YeOldeInvContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    public YeOldeInvContext(DbContextOptions options) : base(options) { }
  }
}