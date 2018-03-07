using System;

namespace p08_Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double distanceFirstPoint = ReturnDistance(x1, y1);
            double distanceSecondPoint = ReturnDistance(x2, y2);
            if (distanceSecondPoint< distanceFirstPoint)
            {
                Console.WriteLine($"({x2}, {y2})");
            }else
            Console.WriteLine($"({x1}, {y1})");
        }

        static double ReturnDistance(double x1, double y1)
        {
            double dstnc = Math.Sqrt((x1 * x1 + y1 * y1));
            return dstnc;
        }
    }
}
