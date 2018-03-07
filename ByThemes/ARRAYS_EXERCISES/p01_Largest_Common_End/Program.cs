using System;
using System.Linq;

namespace p01_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int arrSize = array.Length;
            string[] arraySecond = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int arrSizeSecond = arraySecond.Length;
            int minSize = Math.Min(arrSize, arrSizeSecond);
            int counterLeft = CountMatched(array, arraySecond, minSize);
            Array.Reverse(array);
            Array.Reverse(arraySecond);
            int counterRight = CountMatched(array, arraySecond, minSize);
            int maxMatched = Math.Max(counterLeft, counterRight);
            Console.WriteLine(maxMatched);

        }
        static int CountMatched(string[] array, string[] arraySecond, int minSize)
        {
            int counterLeft = 0;
            for (int i = 0; i < minSize; i++)
            {
                if (array[i] == arraySecond[i])
                {
                    counterLeft++;
                }
                else break;
            }
            return counterLeft;
        }
    }
}
