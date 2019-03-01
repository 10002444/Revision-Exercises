using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int y;

            Console.WriteLine("Type in your first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type in your first number");
            num2 = Convert.ToInt32(Console.ReadLine());

            y = num1 * num2;

            Console.WriteLine($"{num1} x {num2} =");
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
