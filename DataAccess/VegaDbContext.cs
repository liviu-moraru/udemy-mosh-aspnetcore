using Microsoft.EntityFrameworkCore;

namespace vega.DataAccess
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {
            
        }
    }
}