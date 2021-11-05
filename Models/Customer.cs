using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fitwell_mvc.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; } 
        [StringLength(50)]
        public string Name { get; set; }
        public int PhoneNo { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public List<Order> Orders { get; set; }
    }
}