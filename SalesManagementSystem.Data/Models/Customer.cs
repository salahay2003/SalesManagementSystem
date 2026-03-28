using System.ComponentModel.DataAnnotations;

namespace SalesManagementSystem.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string? Name { get; set; }
        [MaxLength(255)]

        public string? FirstName { get; set; }
        [MaxLength(255)]
        public string? LastName { get; set; }
        [MaxLength(255)]
        public string? Phone { get; set; }
        [MaxLength(255)]
        public string? Address1 { get; set; }
        [MaxLength(255)]
        public string? Address2 { get; set; }
        [MaxLength(255)]
        public string? City { get; set; }
        [MaxLength(255)]
        public string? State { get; set; }
        public int? PostalCode { get; set; }
        [MaxLength(255)]
        public string? Country { get; set; }
        
        public decimal? CreditLimit { get; set; }

        /*--------------------------------------------------------*/
        //Relation with Employee
        public int SalesRepNum { get; set; }
        public virtual Employee Employee { get; set; }
        /*--------------------------------------------------------*/
        //Relation with Orders
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        /*--------------------------------------------------------*/
        //Relation with Payment
        public virtual ICollection<Payment> Purchases { get; set; } = new HashSet<Payment>();
        /*--------------------------------------------------------*/
      

    }
}
