using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a");
            float a = Convert.ToSingle(Console.ReadLine()); // Берём из консоли число и сразу конвертируем в float
            Console.WriteLine("b");
            float b = Convert.ToSingle(Console.ReadLine()); // Берём из консоли число и сразу конвертируем в float
            double x = a * b; // Делаем действие
            Console.WriteLine("a = " + a + " b = " + b); // Выводим хуету
            Console.WriteLine();
            Console.WriteLine("x = " + x); // Выводим хуету
        }
    }
}
