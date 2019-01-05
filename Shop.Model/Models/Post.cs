using Shop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Posts")]
    public class Post: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(250)]
        public string Alias { get; set; }

        [Required]
        //Nên để tên class thay vì id của table
        [ForeignKey("PostCategory")]
        public int PostCategoryID { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }

        
        public virtual PostCategory PostCategory { get; set; }
        
        public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}