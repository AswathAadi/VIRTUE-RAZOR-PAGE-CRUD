using Microsoft.EntityFrameworkCore;
using Razor_pages.Model;

namespace Razor_pages.Data
{
    public class RApplicationDbContext : DbContext
    {
        public RApplicationDbContext(DbContextOptions<RApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<RCategory> RCategory { get; set; }
    }
}
