using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Web.Models
{
    public class PostCategoryViewModel
    {
       
        public int PostCategoryID { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }
        
        public string Description { get; set; }

        public int? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        public string Image { get; set; }


        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<PostViewModel> Posts { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreateBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdateBy { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}