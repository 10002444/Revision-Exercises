using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number of the radius to find the area and perimeter of a circle.");
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double area = 2 * pi * radius;
            Console.WriteLine("The Perimeter or Circumference (C=2πr) of your circle is: {0:F2}", area);
        }
    }
}
