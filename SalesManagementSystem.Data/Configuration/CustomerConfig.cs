using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagementSystem.Data.Models;

namespace SalesManagementSystem.Data.Configuration
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Employee)
                .WithMany(e => e.Customers)
                .HasForeignKey(c => c.SalesRepNum)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(c => c.Purchases)
                .WithOne(p => p.Customer)
                .HasForeignKey(p => p.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);
           
            builder.HasMany(c=>c.Orders)
                .WithOne(o=>o.Customer)
                .HasForeignKey(x => x.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
