using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayPointsFirst = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double[] arrayPointsSecond = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Point LeftUpper = Point.CreatePoint(arrayPointsFirst[0], arrayPointsFirst[1]);
            Point DownRight = Point.CreatePoint(arrayPointsFirst[0]+ arrayPointsFirst[2], 
                arrayPointsFirst[1]+ arrayPointsFirst[3]);
            Rectangle firstRctngl = Rectangle.CreateBy2Points(LeftUpper, DownRight);
            Point LeftUpperScnd = Point.CreatePoint(arrayPointsSecond[0], arrayPointsSecond[1]);
            Point DownRightScnd = Point.CreatePoint(arrayPointsSecond[0] + arrayPointsSecond[2],
                arrayPointsSecond[1] + arrayPointsSecond[3]);
            Rectangle secondRctngl = Rectangle.CreateBy2Points(LeftUpperScnd, DownRightScnd);
            bool checkInside = Rectangle.FirstContainsSecond(secondRctngl, firstRctngl);
            if (checkInside)
            {
                Console.WriteLine("Inside");
            }
            else Console.WriteLine("Not inside");
        }
    }
    class Rectangle
    {
        public Point LeftUp { get; set; }
        public Point DownRight { get; set; }

        public static bool FirstContainsSecond(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            double frstX = firstRectangle.LeftUp.X;
            double scndX = secondRectangle.LeftUp.X;
            bool inside = false;
            
            if (frstX<=scndX)
            {
                double frstY = firstRectangle.LeftUp.Y;
                double scndY = secondRectangle.LeftUp.Y;
                if (frstY<=scndY)
                {
                    double frst_rightX = firstRectangle.DownRight.X;
                    double scnd_rightX = secondRectangle.DownRight.X;
                    if (frst_rightX>=scnd_rightX)
                    {
                        double frst_rightY = firstRectangle.DownRight.Y;
                        double scnd_rightY = secondRectangle.DownRight.Y;
                        if (frst_rightY >= scnd_rightY)
                        {
                            inside = true;
                        }
                    }
                }
            }
            return inside;
        }

        public static Rectangle CreateBy2PointsXY(double LeftUpX, double LeftUpY, 
            double RigthDownX, double RightDownY)
        {
            Point LeftUpPoint = Point.CreatePoint(LeftUpX, LeftUpY);
            Point RigthDownPoint = Point.CreatePoint(RigthDownX, RightDownY);
            Rectangle rctngl = new Rectangle() { LeftUp = LeftUpPoint, DownRight = RigthDownPoint };
            return rctngl;
        }
        public static Rectangle CreateBy2Points(Point LeftUpPoint, Point RightDownPoint)
        {
            
            Rectangle rctngl = new Rectangle() { LeftUp = LeftUpPoint, DownRight = RightDownPoint };
            return rctngl;
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
        public static Point CreatePoint(double coordX,double coordY)
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
