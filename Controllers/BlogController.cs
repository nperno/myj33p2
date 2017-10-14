using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using myj33p2api.Blog;

namespace myj33p2api.Controllers
{
    [Route("api/[controller]")]
    public class BlogPostController : Controller
    {
        private readonly BlogContext _context;

        public BlogPostController(BlogContext context)
        {
            _context = context;
        }
     
        [HttpGet]
        public IList<BlogPost> Get()
        {
            return _context.BlogPost.ToList(); ;
        }

        [HttpGet("{id}", Name = "GetPost")]
        public IActionResult GetById(int id)
        {
            var post = _context.BlogPost.FirstOrDefault(t => t.id == id);
            if (post == null)
            {
                return NotFound();
            }
            return new ObjectResult(post);
        }

    }
}
