using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int c1 = int.Parse(Console.ReadLine());
            int d1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a1,0:4D} {b1,0:4D} {c1,0:4D} {d1,0:4D} ");
        }
    }
}
