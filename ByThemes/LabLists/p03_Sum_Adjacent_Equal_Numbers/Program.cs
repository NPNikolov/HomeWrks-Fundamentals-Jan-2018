using System;
using System.Collections.Generic;
using System.Linq;


namespace p03_Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayInt = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            int arrSizeInts = arrayInt.Length;
            List<double> intsLs = new List<double>(arrSizeInts);
            intsLs.InsertRange(0, arrayInt);
            for (int i = 0; i < intsLs.Count - 1; i++)
            {
                if (intsLs[i]==intsLs[i+1])
                {
                    intsLs[i] += intsLs[i + 1];
                    intsLs.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", intsLs));
        }
    }
}
