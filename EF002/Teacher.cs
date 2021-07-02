using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF002
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Groupp> Groupps { get; set; }
        public Teacher()
        {
            Groupps = new List<Groupp>();
        }
    }
}
