using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _004TaskAllWebApi.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
        public Group() {
            Students = new List<Student>();
        }
    }
}
