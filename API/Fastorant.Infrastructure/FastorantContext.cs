using Fastorant.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fastorant.Infrastructure;

public class FastorantContext : DbContext
{
    public FastorantContext(DbContextOptions<FastorantContext> options) 
        : base(options)
    {
    }

    public DbSet<Province> Provinces { get; set; }
    public DbSet<Locality> Localities { get; set; }
    public DbSet<Business> Businesss { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Province>().ToTable("Province");
        modelBuilder.Entity<Locality>().ToTable("Locality");
        modelBuilder.Entity<Business>().ToTable("Business");
    }
}