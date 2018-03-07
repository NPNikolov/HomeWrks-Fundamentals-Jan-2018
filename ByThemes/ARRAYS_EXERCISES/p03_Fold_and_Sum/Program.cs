using System;
using System.Linq;

namespace p03_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            int arrSize = array.Length;

            int baseSize = arrSize / 4;
            for (int i = 0; i < baseSize; i++)
            {
                array[i] += array[2*baseSize - i-1];
                array[4* baseSize -i-1] += array[2 * baseSize + i];
            }
            for (int i = 0; i < baseSize; i++)
            {
                Console.Write(array[baseSize - 1 - i]);
                Console.Write(" ");
            }
            for (int i = 0; i < baseSize; i++)
            {
                Console.Write(array[4*baseSize - 1 - i]);
                if (4 * baseSize - 1 - i>3*baseSize)
                {
                    Console.Write(" ");
                }
                
            }

        }
    }
}
