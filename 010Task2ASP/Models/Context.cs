using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _010Task2ASP.Models
{
    public class Context : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public Context(DbContextOptions<Context> options)
           : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
