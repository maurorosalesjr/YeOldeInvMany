using System.Collections.Generic;

namespace YeOldeInv.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Object { get; set; }
        public string Description { get; set; }
        public int LevelReq { get; set; }
    }
}