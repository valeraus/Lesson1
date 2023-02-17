using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Title
    {
        string title;
        public string Content
        {
            private get
            {
                if (title != null)
                    return title;
                else
                    return "Заголовок відсутній.";
            }
            set
            {
                title = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
