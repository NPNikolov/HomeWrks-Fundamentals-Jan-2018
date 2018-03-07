using System;
using System.Linq;

namespace p08_Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            int arrSize = array.Length;

            while (arrSize>1)
            {
                for (int i = 0; i < arrSize - 1; i++)
                {
                    array[i] += array[i + 1];
                }
                arrSize--;
            }
            Console.WriteLine(array[0]);
        }
    }
}
