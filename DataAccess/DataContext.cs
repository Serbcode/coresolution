using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using CoreSolution.Core.Domain;

namespace CoreSolution.DataAccess
{
    public class DataContext : DbContext
    {

        public DbSet<Role> Roles {get; set;}
        public DbSet<Employee> Employees {get; set;}

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=PromoCodeFactory.sqlite");            
        }
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasMany(e => e.Employees)
                .WithMany(r => r.Roles);

            modelBuilder.Entity<Role>().HasData(FakeData.Roles);
            //modelBuilder.Entity<Employee>().HasData(FakeData.Employees);
        }

    }
}