using System;

namespace p02_Circle_Area_Precision_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = r * r * Math.PI;
            Console.WriteLine($"{area,0:F12}");
        }
    }
}
