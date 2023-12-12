using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogsAndPosts.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogsAndPosts
{
    public class PostInteractions : IPost
    {

        public void AddPost(int blogId, string title, string content)
        {
            var createPost = new Post
            {
                BlogId = blogId,
                Title = title,
                Content = content
            };

            using (var db = new BlogContext())
            {
                var addPost = db.Posts.Add(createPost);

                db.SaveChanges();
            }
        }
        public void DisplayPost(int blogId)
        {
            using (var db = new BlogContext())
            {
                var blogs = db.Blogs.Where(x => x.BlogId == blogId).ToList();
                foreach (var blog in blogs)
                {
                    Console.WriteLine($"Id: {blog.BlogId} - {blog.BlogName}\nList of posts: ");
                    foreach (var post in blog.Posts)
                    {
                        Console.WriteLine($"-- {post.Title} --\n {post.Content}");
                    }
                }
            }
        }
    }
}
