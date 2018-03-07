using System;

namespace p06_Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalcArea(height, width);
            Console.WriteLine(area);
        }

        static double CalcArea(double height, double width)
        {
            return height * width / 2;
        }
    }
}
