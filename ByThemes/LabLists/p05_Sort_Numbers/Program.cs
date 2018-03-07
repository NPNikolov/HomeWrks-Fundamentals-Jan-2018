using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayDbl = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            int arrSize = arrayDbl.Length;
            List<double> dblLs = new List<double>(arrSize);
            dblLs.InsertRange(0, arrayDbl);
            dblLs.Sort();
            Console.WriteLine(string.Join(" <= ", dblLs));
        }
    }
}
