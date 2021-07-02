using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF002
{
    class EFDbContext : DbContext
    {
        public EFDbContext()
         : base("EF002DB")
        { }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Groupp> Groupps { get; set; }
    }
}
