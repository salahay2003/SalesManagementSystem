using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagementSystem.Data.Models;

namespace SalesManagementSystem.Data.Configuration
{
    internal class ProdcutConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(p=>p.ProductLine)
                .WithMany(pl=>pl.Products)
                .HasForeignKey(p=>p.ProductLineId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
