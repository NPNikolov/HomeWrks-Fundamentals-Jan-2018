using System;
using System.Linq;

namespace p08_Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(ushort.Parse).ToArray();
            int arrSize = array.Length;
            int bestStart = 0;
            int bestLength = 1;
            for (int i = 0; i < arrSize - 1; i++)
            {
                int cntr = 0;
                for (int j = i+1; j < arrSize; j++)
                {
                    if (array[i]==array[j])
                    {
                        cntr++;
                    }
                }
                if (bestLength<cntr)
                {
                    bestLength = cntr;
                    bestStart = i;
                }
            }
            
                Console.WriteLine(array[bestStart]);
            
        }
    }
}
