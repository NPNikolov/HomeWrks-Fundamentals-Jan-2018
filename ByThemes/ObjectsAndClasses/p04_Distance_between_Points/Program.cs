using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayPoint1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Point p1 = new Point() { X = arrayPoint1[0], Y = arrayPoint1[1]};
            double[] arrayPoint2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Point p2 = new Point() { X = arrayPoint2[0], Y = arrayPoint2[1] };
            double dstnc = Point.CalcDistance(p1, p2);
            Console.WriteLine($"{dstnc,0:f3}");
        }
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static double CalcDistance(Point point1, Point point2)
        {
            double byX = Math.Pow(point1.X - point2.X, 2);
            double byY = Math.Pow(point1.Y - point2.Y, 2);
            double dstnc = Math.Sqrt(byX + byY);
            return dstnc;
        }
    }
}
