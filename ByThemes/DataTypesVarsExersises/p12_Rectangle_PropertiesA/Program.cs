using System;

namespace p12_Rectangle_PropertiesA
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = width *2+ height*2;
            double area = width * height;
            double square_sum = width * width + height * height;
            double diagonal = Math.Sqrt(square_sum);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
