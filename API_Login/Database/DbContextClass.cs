using API_Login.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace API_Login.Database
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public DbSet<LoginUser_mdl> LoginUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
          
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
