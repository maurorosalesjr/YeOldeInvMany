using System.Collections.Generic;

namespace YeOldeInvMany.Models
{
    public class Item
    {
        public Item()
        {
            this.JoinEntities = new HashSet<CategoryItem>();
        }

        public int ItemId { get; set; }
        public string Object { get; set; }
        public string Description { get; set; }
        public int LevelReq { get; set; }
        public int SellingPrice { get; set; }
        public int EstProfit { get; set; }
        public string AquiredBy { get; set; }

        public virtual ICollection<CategoryItem> JoinEntities { get;}
    }
}
