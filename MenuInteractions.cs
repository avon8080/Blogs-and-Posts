using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogsAndPosts
{
    public class MenuInteractions
    {
        private IPost _postInteractions;
        private IBlog _blogInteractions;

        public MenuInteractions(IPost postInteractions, IBlog blogInteractions)
        {
            _postInteractions = postInteractions;
            _blogInteractions = blogInteractions;
        }

        public void Menu()
        {
            
            bool isTrue = true;
            do
            {
                Console.WriteLine("Enter the corresponding number:\n\t1. Add post\n\t2. Display all posts\n\t3. Add blog\n\t4. Display all blogs\n\t5. Exit\n\tSelection:  ");
            var menuReadline = Console.ReadLine();
            switch (menuReadline)
            {
                case "1": 
                    AddPost();
                    break;
                case "2":
                    DisplayPost();
                    break;
                case "3":
                    _blogInteractions.CreateBlog(GetBlogName());
                    break;
                case "4":
                    _blogInteractions.DisplayBlog(GetBlogName());
                    break;
                case "5":
                    isTrue = false;
                    break;
            }
            } while (isTrue);

        }

        private void AddPost()
        {
            Console.WriteLine("Enter the Id: ");
            var id = Console.ReadLine();
            int parsedId = Factory.CreateHandler().HandleInt(id);
            Console.WriteLine("Enter Title for post: ");
            var title = Console.ReadLine();
            Console.WriteLine("Enter content: ");
            var content = Console.ReadLine();
            _postInteractions.AddPost(parsedId, title, content);
        }

        private void DisplayPost()
        {
            Console.WriteLine("Enter the Id to view: ");
            var id = Console.ReadLine();
            _postInteractions.DisplayPost(Factory.CreateHandler().HandleInt(id));
        }

        private string GetBlogName()
        {
            Console.WriteLine("Enter the blogName");
            var blogName = Console.ReadLine();
            return blogName;
        }
    }
}
