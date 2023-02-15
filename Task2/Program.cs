using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Потрібно: Створити клас з ім'ям Rectangle.
    У тілі класу створити два поля, що описують довжини сторін double side1, side2.
    Створити користувальницький конструктор Rectangle (double side1, double side2), 
    в тілі якого поля side1 і side2 инициализируются значеннями аргументів.
    Створити два методи, що обчислюють площу прямокутника - double AreaCalculator() 
    і периметр прямокутника – double PerimeterCalculator().
    Створити дві властивості double Area і double Perimeter з одним методом доступу get.
    Написати програму, яка приймає від користувача довжини двох сторін прямокутника 
    і виводить на екран периметр і площу.
     */
    class  Rectangle
    {
        double side1, side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        double AreaCalculator()
        {
            return side1 * side2;
        }
        public double Area 
        { 
            get 
            { 
                return this.AreaCalculator(); 
            } 
        }           
        double PerimeterCalculator()
        {
            return 2 * this.side1 + 2 * this.side2;
        }
        public double Perimeter 
        { 
            get
            {
                return this.PerimeterCalculator();
            }
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double side1, side2;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть першу сторону: ");
            side1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть другу сторону: ");
            side2 = Double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Периметр = {rectangle.Perimeter}");
            Console.WriteLine($"Площа = {rectangle.Area}");
            //Dellay
            Console.ReadKey();
        }
    }
}
