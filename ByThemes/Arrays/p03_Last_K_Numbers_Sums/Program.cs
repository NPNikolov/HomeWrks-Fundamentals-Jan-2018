using System;

namespace p03_Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrSyze = int.Parse(Console.ReadLine());
            int nmbrStepsBack = int.Parse(Console.ReadLine());
            
            long[] resultArray = new long[arrSyze];
            resultArray[0] = 1;
            for (int i = 1; i < arrSyze; i++)
            {
                int boundInt = nmbrStepsBack;
                long acmltr = 0;
                for (int j = i-1; j >= 0; j--)
                {
                    acmltr += resultArray[j];
                    boundInt--;
                    if (boundInt == 0) break;
                }
                resultArray[i] = acmltr;
            }
            PrintArray(resultArray, arrSyze);
        }
        static void PrintArray(long[] intArray, int arrSize)
        {
            for (int i = 0; i< arrSize; i++)
            {
                if (i > 0)
                {
                    Console.Write(" ");
                }
                Console.Write(intArray[i]);
            }
        }
    }
}
