using Microsoft.EntityFrameworkCore;
using SquaresApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresApplication.Data
{
    public class DataContext : DbContext
    {
        [MaxLength(10000)]
        public DbSet<Point> Points { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Point>()
            .HasKey(bc => new { bc.X, bc.Y });
        }
    }
}
