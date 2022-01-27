using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL
{
    

    public class ProductEntityConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasIndex(p => p.Bar_Code).IsUnique();

        }
    }
    public class EmployeeEntityConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .HasIndex(e => e.Person_Number).IsUnique()
                ;
            builder
                .HasMany(p => p.Departments)
                ;
            builder
                .HasMany(p => p.Products)
                ;
            builder
                .HasMany(p => p.Mentorship)
                ;
        }
    }
    public class DepartmentEntityConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder
                .HasOne<Employee>(d => d.ResponsibleEmployee)
                .WithMany(e => e.Departments)
                ;

            builder
                .HasMany(d => d.DepartmentsProducts)
                ;
            builder
                .HasIndex(q=>q.Name).IsUnique()
                ;
        }
    }
    public class CampainEntityConfig : IEntityTypeConfiguration<Campain>
    {
        public void Configure(EntityTypeBuilder<Campain> builder)
        {
            builder
                .HasKey(c => c.Id)
                ;
        }
    }
}
