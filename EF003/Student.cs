using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF003
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short Age { get; set; }
        public int? GrouppId { get; set; }
        public Groupp Groupp { get; set; }
    }
}
