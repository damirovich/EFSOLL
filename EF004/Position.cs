using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF004
{
    class Position
    {
        [Key]
        public short Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public Position() {
            Employees = new List<Employee>();
        }
    }
}
