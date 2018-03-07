using System;

namespace p02_Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrSize = int.Parse(Console.ReadLine());

            int[] arrInts = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                arrInts[i] = int.Parse(Console.ReadLine());
            }

            for (int i = arrSize; i > 0; i--)
            {
                if (i<arrSize)
                {
                    Console.Write(" ");
                }
                Console.Write(arrInts[i - 1]);
            }
        }
    }
}
