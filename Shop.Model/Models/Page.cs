using Shop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("Pages")]
    public class Page: Auditable
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(250)]

        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(250)]
        [Required]
        public string Alias { get; set; }

        [Required]
        public string Content { get; set; }
        
    }
}
