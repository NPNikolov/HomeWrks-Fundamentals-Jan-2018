using System;

namespace p09_Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double lineLngth1 = ReturnLineLength(x1, y1, x2, y2);
            double lineLngth2 = ReturnLineLength(x3, y3, x4, y4);

            if (lineLngth1<lineLngth2)
            {
                PrintOrderedPoints(x3, y3, x4, y4);
            }
            else
            {
                PrintOrderedPoints(x1, y1, x2, y2);
            }

        }
        static void PrintOrderedPoints(double x1, double y1, double x2, double y2)
        {
            double distanceFirstPoint = ReturnDistance(x1, y1);
            double distanceSecondPoint = ReturnDistance(x2, y2);
            if (distanceSecondPoint < distanceFirstPoint)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        }
        static double ReturnLineLength(double x1, double y1, double x2, double y2)
        {
            double lngth = Math.Sqrt(Math.Abs((x2 - x1) * (x2 - x1) - (y2 - y1) * (y2 - y1)));
            return lngth;
        }
        static double ReturnDistance(double x1, double y1)
        {
            double dstnc = Math.Sqrt((x1 * x1 + y1 * y1));
            return dstnc;
        }
    }
}
