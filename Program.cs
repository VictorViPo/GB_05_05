using System;
namespace ConsoleApp_C1b3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Input a:");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input b:");

            b = int.Parse(Console.ReadLine());
            
            while (a != b)
            { 
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.WriteLine($"GDC: {a}");
            Console.ReadKey();
        }
    }
}