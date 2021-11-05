using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fitwell_mvc.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        //public List<OrderDetail> OrderDetails { get; set; }
        public List<ProductRate> Rates { get; set; }
    }
}