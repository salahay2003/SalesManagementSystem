using System.ComponentModel.DataAnnotations;

namespace SalesManagementSystem.Data.Models
{
    public class Product
    {
        [Key]
        public int Code { get; set; }
        [MaxLength(255)]
        public string? Name { get; set; }
        public int? Scale { get; set; }
        [MaxLength(255)]
        public string? Vendor { get; set; }
        [MaxLength(255)]
        public string? PdtDescription { get; set; }
        public int? QtyInStock { get; set; }
        public decimal? BuyPrice { get; set; }
        [MaxLength(255)]
        public string? MSRP { get; set; }
        /*---------------------------------------------------*/
        //Relation with Product line
        public int ProductLineId { get; set; }
        public virtual ProductLine ProductLine { get; set; }
        /*---------------------------------------------------*/
        //relation with order_product
        public ICollection<Order_Product> Order_Products { get; set; }
        = new HashSet<Order_Product>();
        /*---------------------------------------------------*/

    }
}
