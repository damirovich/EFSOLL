using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF005
{
    class InitialDB: DropCreateDatabaseAlways<CodeContext>
    {
        protected override void Seed(CodeContext db)
        {
            Blog b1 = new Blog { Name = "Apartment Therapy" };
            Blog b2 = new Blog { Name = "Say Yes " };
            db.Blogs.Add(b1);
            db.Blogs.Add(b2);
            db.SaveChanges();
            Articles a1 = new Articles
            {
                Title = "Дизайн интерьера",
                Text = "стиль жизни и дизайн интерьера,\n" +
                "советы по дизайну, практические советы\n" +
                "по изготовлению изделий из дерева,\n" +
                "руководства по покупкам.",
                Blog = b1
            };
            Articles a2 = new Articles { Title = "Образ жизни", Text = "стиль, дизайн, еда, материнство, путешествия, отношения", Blog = b2 };

            db.Articles.AddRange(new List<Articles> { a1, a2 });
        }
    }
}
