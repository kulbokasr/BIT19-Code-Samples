﻿using Microsoft.EntityFrameworkCore;
using TodoListApplication.Models;

namespace TodoListApplication.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(
                new Todo()
                {
                    Id = 1,
                    Name = "Todo1"
                },
                 new Todo()
                 {
                     Id = 2,
                     Name = "Todo2"
                 },
                new Todo()
                {
                    Id = 3,
                    Name = "Todo3"
                });
        }
    }
}