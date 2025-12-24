using Microsoft.EntityFrameworkCore;

namespace WebAppMVCHON.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<UsersTask> UsersTask { get; set; }

        public DbSet<Country> country { get; set; }
        public DbSet<State> state { get; set; }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<Lab> Lab { get; set; }

        public DbSet<Adhar> Adhar { get; set; }
        public DbSet<Pan> Pan { get; set; }

        public DbSet<Std> Std { get; set; }
        public DbSet<Result> Results { get; set; }

        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<DocDegree> DocDegree { get; set; }
    }
}
