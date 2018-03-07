using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayFirstCircle = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double[] arraySecondCircle = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Circle circle1 = Circle.CreateCircleByXYR(arrayFirstCircle[0], arrayFirstCircle[1], arrayFirstCircle[2]);
            Circle circle2 = Circle.CreateCircleByXYR(arraySecondCircle[0], arraySecondCircle[1], arraySecondCircle[2]);
            bool intersect = Circle.Intersect(circle1, circle2);
            if (intersect)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
        }
    }
    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public static Circle CreateCircleByXYR(double coordX, double coordY, double radius)
        {
            Point center = Point.CreatePoint(coordX, coordY);
            Circle circle = new Circle() { Center = center, Radius = radius };
            return circle;
        }

        public static bool Intersect(Circle circle1, Circle circle2)
        {
            double distance = Point.CalcDistance(circle1.Center, circle2.Center);
            double sumRadiuses = circle1.Radius + circle2.Radius;
            if (distance <= sumRadiuses)
                return true;
            else return false;
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public static Point CreatePointLoad()
        {
            double[] arrayPoint = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Point point = new Point() { X = arrayPoint[0], Y = arrayPoint[1] };
            return point;
        }
        public static Point CreatePoint(double coordX, double coordY)
        {
            Point point = new Point() { X = coordX, Y = coordY };
            return point;
        }
        public static double CalcDistance(Point point1, Point point2)
        {
            double byX = Math.Pow(point1.X - point2.X, 2);
            double byY = Math.Pow(point1.Y - point2.Y, 2);
            double dstnc = Math.Sqrt(byX + byY);
            return dstnc;
        }
    }
}
