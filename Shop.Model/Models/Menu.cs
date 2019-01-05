using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenuID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public int MenuGroupID { get; set; } 

        [ForeignKey("MenuGroupID")]
        public virtual MenuGroup MenuGroup { get; set; }
    }
}