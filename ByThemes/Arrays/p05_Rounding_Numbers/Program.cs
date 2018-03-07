using System;
using System.Linq;

namespace p05_Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int arrSize = array.Length;
            for (int i = 0; i < arrSize; i++)
            {

                Console.WriteLine("{0} => {1}", array[i], Math.Round(array[i], 0, MidpointRounding.AwayFromZero));
            }
        }
    }
}
