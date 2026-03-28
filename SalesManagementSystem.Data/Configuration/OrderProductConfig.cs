using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagementSystem.Data.Models;

namespace SalesManagementSystem.Data.Configuration
{
    public class OrderProductConfig : IEntityTypeConfiguration<Order_Product>
    {
        public void Configure(EntityTypeBuilder<Order_Product> builder)
        {
            builder.HasKey(op => new {op.Id, op.ProductCode, op.OrderId});

            builder.HasOne(op=>op.Product)
                .WithMany(p=>p.Order_Products)
                .HasForeignKey(op=>op.ProductCode)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(op=>op.Order)
                .WithMany(o=>o.Order_Products)
                .HasForeignKey(op=>op.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
