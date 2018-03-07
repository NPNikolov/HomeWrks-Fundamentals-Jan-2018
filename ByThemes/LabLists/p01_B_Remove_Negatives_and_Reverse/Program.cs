using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_B_Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int arrSize = array.Length;
            List<int> lstInts = new List<int>();
            for (int i = 0; i < arrSize; i++)
            {
                if (array[i]>=0)
                {
                    lstInts.Add(array[i]);
                }
            }
            if (lstInts.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = lstInts.Count; i > 0; i--)
                {
                    Console.Write(lstInts[i - 1]);
                    Console.Write(" ");
                }
            }

        }
    }
}
