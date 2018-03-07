using System;

namespace p11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;
            if (figure=="triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = TriangleArea(side, height);
            }else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = RectangleArea(width, height);
            }
            else
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(radius, 2);
            }
            Console.WriteLine($"{area,0:f2}");
        }

        private static double RectangleArea(double width, double height)
        {
            return width * height;
        }

        static double TriangleArea(double side, double height)
        {
            return side * height/2;
        }
    }
}
