using System.Collections.Generic;

namespace ShopApplication.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; }
    }
}
