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
    [Table("PostCategories")]
    public class PostCategory: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostCategoryID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(250)]
        public string Alias { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
        
        public int? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(250)]
        public string Image { get; set; }


        public bool? HomeFlag { get; set; }
        
        public virtual IEnumerable<Post> Posts { get; set; }
     
    }
}
