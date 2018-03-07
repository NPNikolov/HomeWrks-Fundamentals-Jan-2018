using System;

namespace p03_Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = double.Parse(Console.ReadLine());
            a1 = a1 * 1.60934;
            Console.WriteLine($"{a1, 0:F2}");
        }
    }
}
