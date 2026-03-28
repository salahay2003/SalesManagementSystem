using System.ComponentModel.DataAnnotations;

namespace SalesManagementSystem.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string? FirstName { get; set; }
        [MaxLength(255)]
        public string? LastName { get; set; }
        [MaxLength(255)]
        public string? Extension { get; set; }
        [MaxLength(255)]
        public string? Email { get; set; }
        [MaxLength(100)]
        public string? JobTitle { get; set; }
        /*---------------------------------------------------*/
        //Relation with customer
        public virtual ICollection<Customer> Customers { get; set; }
        /*---------------------------------------------------*/
        //Relation with office
        public int OfficeCode { get; set; }
        public virtual Office Office { get; set; }
        /*---------------------------------------------------*/
        //Self Relation
        public int? ReportsTo { get; set; }
        public virtual Employee Supervisor { get; set; }
        /*---------------------------------------------------*/
        public virtual ICollection<Employee> Employees { get; set; }
        = new HashSet<Employee>();
        /*---------------------------------------------------*/
    }
}
