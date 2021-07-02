using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF005
{
    class CodeContext:DbContext
    {
        public  DbSet<Articles> Articles { get; set; }
        public  DbSet<Blog> Blogs { get; set; }
        static CodeContext()
        {
            Database.SetInitializer<CodeContext>(new InitialDB());
        }
        
       
       
    }
}
