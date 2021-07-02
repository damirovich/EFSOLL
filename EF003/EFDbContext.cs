using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF003
{
    class EFDbContext:DbContext
    {
        public EFDbContext() :
            base("EFDbContext")
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Groupp> Groupps { get; set; }
    }
}
