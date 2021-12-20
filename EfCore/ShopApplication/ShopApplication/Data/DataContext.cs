using Microsoft.EntityFrameworkCore;
using ShopApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Item> Items { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
    : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Shop>().HasData(
        //        new Shop()
        //        {
        //            Id = 1,
        //            Name = "Shop1",
        //        },
        //         new Shop()
        //         {
        //             Id = 2,
        //             Name = "Shop2"
        //         },
        //        new Shop()
        //        {
        //            Id = 3,
        //            Name = "Shop3"
        //        }
        //        );
        //    modelBuilder.Entity<Item>().HasData(
        //        new Item()
        //        {
        //            Id = 1,
        //            Name = "Item1",
        //            ShopId = 1
        //        },
        //         new Item()
        //         {
        //            Id = 2,
        //            Name = "Item2",
        //            ShopId = 1
        //         },
        //        new Item()
        //        {
        //            Id = 3,
        //            Name = "Item3",
        //            ShopId = 1
        //        },
        //        new Item()
        //        {
        //            Id = 4,
        //            Name = "Item4",
        //            ShopId = 2
        //        },
        //        new Item()
        //        {
        //            Id = 5,
        //            Name = "Item5",
        //            ShopId = 2
        //        }
        //        );
            
        //}
    }
}
