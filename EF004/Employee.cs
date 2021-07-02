using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF004
{
    class Employee
    {
        [Key]
        public int IdEmployee { get; set; }
        [Required(ErrorMessage ="ФИО обязательно")]
        [MaxLength(50)]
        public string FullName { get; set; }
        [ForeignKey("Position")]
        public short PositionId { get; set; }
        public Position Position { get; set; }
    }
}
