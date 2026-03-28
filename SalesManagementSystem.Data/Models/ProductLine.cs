using System.ComponentModel.DataAnnotations;

namespace SalesManagementSystem.Data.Models
{
    public class ProductLine
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string? DescInText { get; set; }
        [MaxLength(255)]
        public string? DescInHTML { get; set; }
        [MaxLength(100)]
        public string? Image {  get; set; }
        /*---------------------------------------------------*/
        public virtual ICollection<Product> Products { get; set; }
        = new HashSet<Product>();
        /*---------------------------------------------------*/

    }
}
