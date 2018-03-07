using System;

namespace p02_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            width = width * height;
            
            Console.WriteLine($"{width, 0:F2}");
        }
    }
}
