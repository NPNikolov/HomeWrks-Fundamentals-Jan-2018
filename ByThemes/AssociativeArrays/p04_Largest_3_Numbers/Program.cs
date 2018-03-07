using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var dblLs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            var rslt = dblLs.OrderByDescending(x => x).Take(3);
            Console.WriteLine(string.Join(" ", rslt));

        }
    }
}
