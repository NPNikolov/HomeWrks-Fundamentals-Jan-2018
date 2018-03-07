using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_Min_Max_Sum_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmbr = int.Parse(Console.ReadLine());
            List<int> nmbrsLs = new List<int>();
            for (int i = 0; i < nmbr; i++)
            {
                nmbrsLs.Add(int.Parse(Console.ReadLine()));
            }
            int sum = nmbrsLs.Sum();
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Min = {0}", nmbrsLs.Min());
            Console.WriteLine("Max = {0}", nmbrsLs.Max());
            Console.WriteLine("Average = {0}", nmbrsLs.Average());
        }
    }
}
