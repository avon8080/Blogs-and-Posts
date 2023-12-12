using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogsAndPosts
{
    public interface IPost
    {
        void DisplayPost(int blogId);
        void AddPost(int blogId, string title, string content);
    }
}
