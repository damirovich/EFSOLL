using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _004TaskAllWebApi.Models
{
    public class ContextDB:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public ContextDB(DbContextOptions<ContextDB> options)
          : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
