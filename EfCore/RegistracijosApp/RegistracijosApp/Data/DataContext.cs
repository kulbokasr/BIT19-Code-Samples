using Microsoft.EntityFrameworkCore;
using RegistracijosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Reiksme> Reiksmes { get; set; }
        public DbSet<Pozymis> Pozymiai { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
: base(options)
        {
        }

    }
}
