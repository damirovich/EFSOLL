using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF005
{
    class Articles
    {
        [Key]
        public int IdArticles { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
