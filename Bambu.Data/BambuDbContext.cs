using Bambu.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Bambu.Data
{
    public class BambuDbContext : DbContext
    {
        public BambuDbContext(DbContextOptions<BambuDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Salesperson> Salesperson { get; set; }
        public virtual DbSet<SalesGroup> SalesGroup { get; set; }
    }
}