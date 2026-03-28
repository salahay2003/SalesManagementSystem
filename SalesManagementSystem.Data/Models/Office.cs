using System.ComponentModel.DataAnnotations;

namespace SalesManagementSystem.Data.Models
{
    public class Office
    {
        [Key]
        public int Code { get; set; }
        [MaxLength(255)]
        public string? City { get; set; }
        [MaxLength(255)]
        public string? Phone { get; set; }
        [MaxLength(255)]
        public string? Address1 { get; set; }
        [MaxLength(255)]
        public string? Address2 { get; set; }
        [MaxLength(255)]
        public string? State { get; set; }
        [MaxLength(255)]
        public string? Country { get; set; }
        public int ?PostalCode  { get; set; }
        [MaxLength(200)]
        public string? Territory { get; set; }
        /*-----------------------------------------*/
        public virtual ICollection<Employee> Employees { get; set; }
         = new HashSet<Employee>();

    }
}
