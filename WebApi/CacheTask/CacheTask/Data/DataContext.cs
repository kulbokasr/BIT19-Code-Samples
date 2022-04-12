using CacheTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheTask.Data
{
    public class DataContext : DbContext
    {
        public DbSet<SomeModel> SomeInfo { get; set; }
        public DbSet<KeyModel> Keys { get; set; }
        public DbSet<ValueModel> Values { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
