using Microsoft.EntityFrameworkCore;

namespace WebAppMVCHON.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<UsersTask> UsersTask { get; set; }
    }
}
