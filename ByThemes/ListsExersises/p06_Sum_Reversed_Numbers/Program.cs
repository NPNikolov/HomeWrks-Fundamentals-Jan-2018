using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int arrSize = array.Length;
            double sum = 0;
            
            for (int i = 0; i < arrSize; i++)
            {
                sum += ReverseDgts(array[i]);
            }
            Console.WriteLine($"{sum,0:f0}");
        }

        static double ReverseDgts(string tmp)
        {
            char[] arrString = tmp.ToCharArray();
            double sum = 0;
            double dgt = 0;
            for (int i = 0; i < arrString.Length; i++)
            {
                dgt = double.Parse(arrString[i].ToString());
                sum += dgt * Math.Pow(10, i*1.0);
            }

            return sum;
        }
    }
}
