using System;
using System.Linq;

namespace p11_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int arrSize = array.Length;
            bool check = false;
            int indx = 0;
            for (int i = 0; i < arrSize; i++)
            {
                int sumLeft = GetSumLeft(array,i);
                int sumRight = GetSumRight(array, i, arrSize);
                if (sumLeft==sumRight)
                {
                    check = true;
                    indx = i;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine(indx);
            }
            else Console.WriteLine("no");
        }

        static int GetSumLeft(int[] array, int indx)
        {
            int sum = 0;
            for (int i = 0; i < indx; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static int GetSumRight(int[] array, int indx, int arrSize)
        {
            int sum = 0;
            for (int i = indx+1; i < arrSize; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
