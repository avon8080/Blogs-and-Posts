using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogsAndPosts.Models;

namespace BlogsAndPosts
{
    public class BlogInteractions : IBlog
    {
        public void CreateBlog(string blogName)
        {
            var blog = new Blog();
            blog.BlogName = blogName;
            using (var db = new BlogContext())
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
            }
        }

        public void DisplayBlog(string blogName)
        {
            using (var db = new BlogContext())
            {
                var blogs = db.Blogs.Where(x => x.BlogName.Contains(blogName)).ToList();
                foreach (var blog in blogs)
                {
                    Console.WriteLine($"Id. {blog.BlogId}: {blog.BlogName}\nNumber of posts: {blog.Posts.Count} ");
                }
            }
        }
    }
}
