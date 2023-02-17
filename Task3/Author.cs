using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Author
    {
        string author;
        public string Content
        {
            private get
            {
                if (author != null)
                    return author;
                else
                    return "Автор відсутній.";
            }
            set
            {
                author = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
