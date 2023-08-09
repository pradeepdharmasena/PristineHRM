using Microsoft.EntityFrameworkCore;
using PristineHRM.Models;

namespace PristineHRM.Repository
{
    public class EmployeesDbContext:DbContext
    {
        public DbSet<Employee> Emplyees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost; database=mydb; uid=root; password=Yatipasgama#1";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>(entity => {
                entity.HasIndex(e => e.empNo).IsUnique();
            });
        }

    }
}