using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogsAndPosts
{
    public interface IBlog
    {
        void CreateBlog(string blogName);
        void DisplayBlog(string blogName);
    }
}
