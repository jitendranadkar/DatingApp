using AngularWithCoreAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AngularWithCoreAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}