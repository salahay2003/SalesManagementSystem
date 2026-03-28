using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagementSystem.Data.Models;

namespace SalesManagementSystem.Data.Configuration
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasOne(e => e.Office)
                .WithMany(o => o.Employees)
                .HasForeignKey(e => e.OfficeCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e=>e.Supervisor)
                .WithMany(s=>s.Employees)
                .HasForeignKey(e=>e.ReportsTo)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
