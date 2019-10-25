using Microsoft.EntityFrameworkCore;
using WFLF.Entities;

namespace WFLF.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User() { Id=1, Username="mwalters", FirstName = "Mike", LastName = "Walters", Role = Role.Admin });
        }
    }
}