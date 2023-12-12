using System.ComponentModel.Design;

namespace BlogsAndPosts
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuInteractions menu = new MenuInteractions(Factory.CreatePost(), Factory.CreateBlog());
            menu.Menu();
            
        }
    }
}