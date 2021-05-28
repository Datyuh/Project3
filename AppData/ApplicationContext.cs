using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Project3.AppData
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<Loggings> Loggings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<UserTask> UsersTask { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["WorkDataBase"].ConnectionString);
        }

    }
}
