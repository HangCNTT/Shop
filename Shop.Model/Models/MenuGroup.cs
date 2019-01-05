using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        public int MenuGroupID { get; set; }

        [Required]
        [StringLength(250)]
        public string NameMG { get; set; }

        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}
