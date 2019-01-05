using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        [Required]
        [StringLength(250)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(250)]
        public string CustomerAddress { get; set; }

        [Required]
        [StringLength(250)]
        public string CustomerEmail { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerMobile { get; set; }

        [Required]
        [StringLength(250)]
        public string CustomerMessage { get; set; }
        
        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(250)]
        public string CreateBy { get; set; }

        [Required]
        [StringLength(250)]
        public string PaymentMethod { get; set; }

        [Required]
        [StringLength(250)]
        public string PaymentStatus { get; set; }

        public bool? Status { get; set; }
    }
}
