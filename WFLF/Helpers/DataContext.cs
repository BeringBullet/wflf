using Microsoft.EntityFrameworkCore;
using WFLF.Entities;

namespace WFLF.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}