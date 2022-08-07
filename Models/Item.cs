using System.Collections.Generic;

namespace YeOldeInvMany.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Object { get; set; }
        public string Description { get; set; }
        public int LevelReq { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
