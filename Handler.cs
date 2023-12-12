using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogsAndPosts
{
    public class Handler
    {
        public int HandleInt(string value)
        {
            int parsedValue = 0;
            try
            {
                parsedValue = int.Parse(value);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"-- {value} must be a number --");
            }

            return parsedValue;
        }
    }
}
