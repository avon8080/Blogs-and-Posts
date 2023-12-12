using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogsAndPosts
{
    public static class Factory
    {

        public static IBlog CreateBlog()
        {
            return new BlogInteractions();
        }

        public static IPost CreatePost()
        {
            return new PostInteractions();
        }

        public static Handler CreateHandler()
        {
            return new Handler();
        }
    }
}
