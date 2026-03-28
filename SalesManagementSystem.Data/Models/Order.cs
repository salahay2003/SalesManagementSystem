using System.ComponentModel.DataAnnotations;

namespace SalesManagementSystem.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime? OrderDate   { get; set; }
        public DateTime? RequireDate   { get; set; }
        public DateTime? ShippedDate   { get; set; }
        public int? Status { get; set; }
        [MaxLength(255)]
        public string? Comments { get; set; }
        /*---------------------------------------------------*/
        //Relation with customer
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        /*---------------------------------------------------*/
        //Relation with Order-Product
        public virtual ICollection<Order_Product> Order_Products { get; set; }
        = new HashSet<Order_Product>();
        /*---------------------------------------------------*/

    }
}
