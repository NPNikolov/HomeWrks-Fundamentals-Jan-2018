using System;

namespace p07_Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");
        }
    }
}
