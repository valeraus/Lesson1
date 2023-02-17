using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Book
    {
        // Поля
        Title title = null;
        Author author = null;
        Content content = null;
        void InitializeBook()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }
        public Book(string title)
        {
            InitializeBook();
            this.title.Content = title;
        }
        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }
        public string Author
        {
            set
            {
                this.author.Content = value;
            }
        }
        public string Content
        {
            set
            {
                this.content.Content1 = value;
            }
        }
    }
}
