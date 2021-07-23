using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _004TaskAllWebApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public short Age { get; set; }
        public string PhoneNumber { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }
    }
}
