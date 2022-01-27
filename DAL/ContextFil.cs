using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DAL
{
    public class ContextFil : DbContext
    {
        public DbSet<Product>? Products { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Campain>? Campains { get; set; }
        public DbSet<PhoneNumber>? PhoneNumber { get; set; }
        public DbSet<EMail>? EMail { get; set; }
        public DbSet<DepartmentProduct>? DepartmentsProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connectionString = @"Server=localhost\SQLEXPRESS;Database=Soja3;Integrated Security=True;";
            builder.UseSqlServer(connectionString)
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder)
                ;
            modelBuilder.Entity<PhoneNumber>()
                .HasKey(e => new { e.EmployeeId, e.Value })
                ;
            modelBuilder.Entity<EMail>()
                .HasKey(e => new { e.EmployeeId, e.Value })
                ;
            modelBuilder.Entity<DepartmentProduct>()
                  .HasKey(e => new { e.ProductsId, e.DepartmentsId })
                  ;
            modelBuilder.Entity<DepartmentProduct>()
                .HasOne(d => d.Department)
                .WithMany(d => d.DepartmentsProducts)
                .HasForeignKey(d => d.DepartmentsId)
                .OnDelete(DeleteBehavior.NoAction)
                ;
            modelBuilder.Entity<DepartmentProduct>()
                .HasOne(d => d.Product)
                .WithMany(d => d.DepartmentsProducts)
                .HasForeignKey(d => d.ProductsId)
                .OnDelete(DeleteBehavior.NoAction)
                ;
            //Database
            Data.Seed(modelBuilder);

        }
    }
}

