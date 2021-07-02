using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF004
{
    class EFDbContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         
            base.OnModelCreating(modelBuilder);
        }


    }
}
