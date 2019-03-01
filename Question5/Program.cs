using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,j;

            Console.WriteLine("Enter a number to get a multiplication table up to 10. \n");

            Console.Write("Input the number (Table to be calculated) : ");
            x = Convert.ToInt32(Console.ReadLine());
            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} + {1} = {2} \n",x,j,x*j);
            }
        }
    }
}
