using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF005
{
    class Blog
    {
        [Key]
        public int IdBlog { get; set; }
        [Required(ErrorMessage ="Наименование блога обязательно")]
        public string Name { get; set; }
        public ICollection<Articles> Articles { get; set; }
        public Blog() {
            Articles = new List<Articles>();
        }
    }
}
