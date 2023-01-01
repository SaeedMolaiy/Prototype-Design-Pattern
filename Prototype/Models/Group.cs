using System.Collections.Generic;

namespace Prototype.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }  
    }
}
