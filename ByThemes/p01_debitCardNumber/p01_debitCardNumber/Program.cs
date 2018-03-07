using System;

namespace p01_debitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int c1 = int.Parse(Console.ReadLine());
            int d1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a1, 0:D4} {b1,0:D4} {c1,0:D4} {d1,0:D4}");
        }
    }
}
