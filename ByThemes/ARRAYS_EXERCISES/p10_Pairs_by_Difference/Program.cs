using System;
using System.Linq;

namespace p10_Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int arrSize = array.Length;
            int diff = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < arrSize-1; i++)
            {
                int frstNm = array[i];
                for (int j = i+1; j < arrSize; j++)
                {
                    int secndNm = array[j];
                    if (Math.Abs(frstNm - secndNm)==Math.Abs(diff))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
