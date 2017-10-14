using myj33p2api.Blog;
using System.Linq;

namespace myj33p2api.Utility
{
    public static class DbInitializer
    {
        public static void Initialize(BlogContext context)
        {
         
            // Look for any Blog Posts.
            if (context.BlogPost.Any())
            {
                return;   // DB has been seeded
            }

            var blogposts = new BlogPost[]
            {
                new BlogPost()
                {
                    id = 1,
                    PostName = "name of post 1",
                    PostBody = "this should be HTML 1",
                    HeroImage = "https://d30y9cdsu7xlg0.cloudfront.net/png/2648-200.png",
                    SortOrder = 1
                },
                new BlogPost()
                {
                    id = 2,
                    PostName = "name of post 2",
                    PostBody = "this should be HTML 2",
                    HeroImage = "https://d30y9cdsu7xlg0.cloudfront.net/png/2648-200.png",
                    SortOrder = 2
                },
                new BlogPost()
                {
                    id = 3,
                    PostName = "name of post 3",
                    PostBody = "this should be HTML 3",
                    HeroImage = "https://d30y9cdsu7xlg0.cloudfront.net/png/2648-200.png",
                    SortOrder = 3
                }
            };

            foreach (BlogPost b in blogposts)
            {
                context.BlogPost.Add(b);
            }

            context.SaveChanges();
        }

    }
}
