using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Point[] arrayPoints = new Point[n];
            
            for (int i = 0; i < n; i++)
            {
                arrayPoints[i] = Point.CreatePointLoad();
            }
            int[] pointsArr = FindClosesPoints(arrayPoints);
            double dstnc = Point.CalcDistance(arrayPoints[pointsArr[0]], arrayPoints[pointsArr[1]]);
            Console.WriteLine($"{dstnc,0:f3}");
            Console.WriteLine($"({arrayPoints[pointsArr[0]].X}, {arrayPoints[pointsArr[0]].Y})");
            Console.WriteLine($"({arrayPoints[pointsArr[1]].X}, {arrayPoints[pointsArr[1]].Y})");
        }

        private static int[] FindClosesPoints(Point[] arrayPoints)
        {
            int sizeArr = arrayPoints.Length;
            double distnc = double.MaxValue;
            int resi = 0;
            int resj = 0;
            for (int i = 0; i < sizeArr; i++)
            {
                for (int j = 0; j < sizeArr; j++)
                {
                    if (!(i==j))
                    {
                        double crrntDstnc = Point.CalcDistance(arrayPoints[i], arrayPoints[j]);
                        if (distnc>crrntDstnc)
                        {
                            resi = i;
                            resj = j;
                            distnc = crrntDstnc;
                        }
                    }
                }
            }
            int[] arrRslt = new int[] { resi,resj};
            return arrRslt;
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
        public static double CalcDistance(Point point1, Point point2)
        {
            double byX = Math.Pow(point1.X - point2.X, 2);
            double byY = Math.Pow(point1.Y - point2.Y, 2);
            double dstnc = Math.Sqrt(byX + byY);
            return dstnc;
        }
    }
}
