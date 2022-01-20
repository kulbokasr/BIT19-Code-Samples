using Microsoft.EntityFrameworkCore;
using StudentApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Data
{
    public class DataContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Sex> Sexes { get; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}