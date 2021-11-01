using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fitwell_mvc.Models
{
    public class ProductRate
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; } 
        [Column(TypeName = "decimal(18,2)")]     
        public decimal Rate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DesignerRate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SscRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Product Product { get; set; }
    }
}