using System.ComponentModel.DataAnnotations;

namespace SalesManagementSystem.Data.Models
{
    public class Order_Product
    {
        
        public int Id { get; set; }
        public int? Qty { get; set; }
        public decimal? PriceEach { get; set; }
        /*---------------------------------------------------*/
        //Relation with Order
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        /*---------------------------------------------------*/
        public int ProductCode { get; set; }
        public virtual Product Product { get; set; }
        /*---------------------------------------------------*/

    }
}
