using Microsoft.EntityFrameworkCore;

namespace OpenEcologyApp.Data
{
    public class EcologyDbContext : DbContext
    {
        public EcologyDbContext(DbContextOptions<EcologyDbContext> options)
            : base(options)
        {
        }

        public DbSet<EcologyData> EcologyItems { get; set; } = default!;
    }
}
