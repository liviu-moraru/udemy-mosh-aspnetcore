using Microsoft.EntityFrameworkCore;
using Vega.Entities;

namespace vega.DataAccess
{
    public sealed class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}