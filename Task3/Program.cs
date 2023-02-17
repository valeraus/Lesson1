using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    потрібно:
    Створити клас Book. Створити класи Title, Author і Content, 
    кожен з яких повинен містити одне строкове поле і метод void Show().
    Реалізуйте можливість додавання в книгу назви книги, імені автора і змісту.
    Виведіть на екран різними кольорами за допомогою методу Show () назва книги, ім'я автора та зміст.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Book book1 = new Book("1943");
            book1.Author = "Джордж Орвелл";
            book1.Content = "Глава 1\r\n\r\nСтояла ясна та прохолодна квітнева днина, на годинниках пробило тринадцяту годину.\n " +
                "Вінстон Сміт , притискуючи підборіддя до грудей щоб сховатися від підступного вітру,\n " +
                "швидко ковзнув крізь скляні двері великого панельного будинку що звався \"Перемога\",\n " +
                "але не достатньо швидко щоб завадити вихру з піску та пилюки увійти разом з ним.";

            book1.Show();

            //Dellay
            Console.ReadKey();
        }
    }
}
