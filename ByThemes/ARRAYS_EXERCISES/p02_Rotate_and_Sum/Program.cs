using System;
using System.Linq;

namespace p02_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            int arrSize = array.Length;
            int numRotations = int.Parse(Console.ReadLine());
            
                string rotatedSumStr = GetRotadedSum(numRotations, array, arrSize);
                Console.WriteLine(rotatedSumStr);
            
        }

        static string GetRotadedSum(int numRotations, long[] array, int arrSize)
        {
            long[] sumArray = new long[arrSize];
            //SumArrays(arrSize, sumArray, array);
            for (int i = 1; i <= numRotations; i++)
            {
                RotateArray(array, arrSize);
                SumArrays(arrSize, sumArray, array);
            }
            string reslt = string.Join(" ", sumArray);
            return reslt;
        }

        static void SumArrays(int arrSize, long[] sumArray, long[] array)
        {
            for (int i = 0; i < arrSize; i++)
            {
                sumArray[i] += array[i];
            }
        }

        static void RotateArray(long[] array, int arrSize)
        {
            long lastElmnt = array[arrSize - 1];
            for (int i = arrSize - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastElmnt;
        }
    }
}
