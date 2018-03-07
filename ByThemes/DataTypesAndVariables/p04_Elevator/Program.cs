using System;

namespace p04_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            double nmbrCourses = n / (1.0 * p);
            nmbrCourses = Math.Ceiling(nmbrCourses);
            Console.WriteLine(nmbrCourses);

        }
    }
}
