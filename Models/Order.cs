using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fitwell_mvc.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OrderValue { get; set; }
        public DateTime DeliveryDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public Customer Customer { get; set; }
    }
}