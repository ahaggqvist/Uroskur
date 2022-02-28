using Microsoft.EntityFrameworkCore;
using Uroskur.Model;

namespace Uroskur.DataAccess;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<StravaUser>? StravaUsers { get; set; }

    public DbSet<GoogleUser>? GoogleUsers { get; set; }

    public DbSet<Setting>? Settings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StravaUser>()
            .HasAlternateKey(u => u.AthleteId);
    }
}