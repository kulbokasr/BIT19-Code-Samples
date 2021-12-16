using System;

namespace ShopApplication.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Shop Shop { get; set; }
        public int ShopId { get; set; }
        public DateTime ExpirityDate { get; set; } = DateTime.UtcNow;
    }
}
