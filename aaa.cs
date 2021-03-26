using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b");
            double b = Convert.ToDouble(Console.ReadLine());
            double x = a * b;
            Console.WriteLine("a = " + a.ToString() + " b = " + b.ToString());
            Console.WriteLine();
            Console.WriteLine("x = " + x);
        }
    }
}
