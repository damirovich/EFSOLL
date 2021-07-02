using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF003
{
    class Groupp
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public ICollection<Student> Students { get; set; }
        public Groupp() {
            Students = new List<Student>();
        }
    }
}
