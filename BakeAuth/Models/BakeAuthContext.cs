using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BakeAuth.Models 
{
  public class BakeAuthContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treat> treats { get; set; }
    public DbSet<Flavor> flavors { get; set; }
    public DbSet<TreatFlavor> treatFlavors { get; set; }
    public BakeAuthContext(DbContextOptions options) : base(options) { } 
  }
}