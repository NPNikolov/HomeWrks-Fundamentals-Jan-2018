using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int arrSize = array.Length;
            List<int> squareNums = new List<int>();
            for (int i = 0; i < arrSize; i++)
            {
                
                if (IsPerfectSquare(1.0 * array[i]))
                {
                    squareNums.Add(array[i]);
                }
            }
            squareNums.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squareNums));
        }
        static bool IsPerfectSquare(double input)
        {
            var sqrt = Math.Sqrt(input);
            return Math.Abs(Math.Ceiling(sqrt) - Math.Floor(sqrt)) < Double.Epsilon;
        }

    }
}
