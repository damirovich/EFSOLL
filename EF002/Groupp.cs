using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF002
{
    public class Groupp
    {
        public int Id { get; set; }
        public string NameGroup { get; set; }
        public short StudentCount { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public Groupp()
        {
            Teachers = new List<Teacher>();
        }
    }
}
