
using Microsoft.EntityFrameworkCore;
using Angular_2;
using Vega.Model;

namespace Angular_2.Persitence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) 
          : base(options)
        {
        }

        public DbSet<Make> Makes { get; set; }
      //  public DbSet<Feature> Features { get; set; }
    }
}