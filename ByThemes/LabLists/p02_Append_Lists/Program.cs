using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            int arrSize = array.Length;
            List<int> lstInts = new List<int>();
            Array.Reverse(array);
            for (int i = 0; i < arrSize; i++)
            {
                int[] arrayInt = array[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int arrSizeInts = arrayInt.Length;
                List<int> intsLs = new List<int>(arrSizeInts);
                intsLs.InsertRange(0, arrayInt);
                //intsLs.Sort();
                Console.Write(string.Join(" ", intsLs));
                Console.Write(" ");
            }
        }
    }
}
