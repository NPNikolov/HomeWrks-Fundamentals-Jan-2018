using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int arrSize = array.Length;
            List<int> lstNums = new List<int>();
            for (int i = 0; i < arrSize; i++)
            {
                if (! lstNums.Contains(array[i]))
                {
                    lstNums.Add(array[i]);
                }
            }
            lstNums.Sort();
            for (int i = 0; i < lstNums.Count; i++)
            {
                int countr = 0;
                for (int j = 0; j < arrSize; j++)
                {
                    if (lstNums[i]==array[j])
                    {
                        countr++;
                    }
                }
                Console.WriteLine($"{lstNums[i]} => {countr}");
            }
        }
    }
}
