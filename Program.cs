using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            Triangle triangle = new Triangle(3, 4, 5);

            Console.WriteLine("Circle Info:");
            circle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Rectangle Info:");
            rectangle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Triangle Info:");
            triangle.PrintInfo();

            Console.ReadKey();

        }
    }
}
