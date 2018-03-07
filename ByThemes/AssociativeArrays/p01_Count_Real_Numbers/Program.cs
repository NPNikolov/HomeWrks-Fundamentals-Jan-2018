using System;
using System.Collections.Generic;
using System.Linq;


namespace p01_Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            int arrSize = array.Length;
            var dctnrNmbrs = new SortedDictionary<double, int>();
            foreach (var item in array)
            {
                bool found = dctnrNmbrs.TryGetValue(item, out int cntr);
                if (found)
                {
                    cntr++;
                }
                else cntr = 1;
                dctnrNmbrs[item] = cntr;
            }
            foreach (var item in dctnrNmbrs)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
