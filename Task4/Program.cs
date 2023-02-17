using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    потрібно:
    Створити класи Point і Figure.
    Клас Point повинен містити два цілочисельних поля і одне строкове поле.
    Створити три властивості з одним методом доступу get.
    Створити користувальницький конструктор, в тілі якого проініціалізіруйте поля значеннями аргументів. 
    Клас Figure повинен містити конструктори, які приймають від 3-х до 5-ти аргументів типу Point.
    Створити два методи: double LengthSide (Point A, Point B), який розраховує довжину сторони багатокутника; 
    void PerimeterCalculator (), який розраховує периметр багатокутника.
    Написати програму, яка виводить на екран назву і периметр багатокутника.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(0, 0, "A"), new Point(0, 5, "B"), new Point(8, 5, "C"), new Point(8, 0, "D"));

            Console.Write("{0}, P = ", figure.Type);

            figure.PerimeterCalculator();

            // Delay.
            Console.ReadKey();
        }
    }
}
