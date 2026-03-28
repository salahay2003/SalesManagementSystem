using System.ComponentModel.DataAnnotations;

namespace SalesManagementSystem.Data.Models
{
    public class Payment
    {
        [Key]
        public string CheckNum { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? Amount { get; set; }
        /*---------------------------------------------------*/
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
