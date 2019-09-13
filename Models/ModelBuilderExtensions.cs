using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 1,
                        Name = "Basant",
                        Department = Dept.IT,
                        Email = "Basant@gmail.com"
                    },
                    new Employee
                    {
                        Id = 2,
                        Name = "Ved",
                        Department = Dept.HR,
                        Email = "Ved@gmail.com"
                    }
                );
        }
    }
}