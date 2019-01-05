using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreateBy { set; get; }
        DateTime? UpdatedDate { get; set; }
        string UpdateBy { get; set; }
        string MetaKeyword { set; get; }
        string MetaDescription { get; set; }
        bool Status { get; set; }
    }
}
