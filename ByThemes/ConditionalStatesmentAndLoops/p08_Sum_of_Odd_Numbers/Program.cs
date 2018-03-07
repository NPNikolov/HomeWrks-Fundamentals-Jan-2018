using System;

namespace p08_Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            for (int i = 0; i <n; i++)
            {
                int oddNumber = 2 * i + 1;
                sumOdd = sumOdd + oddNumber;
                Console.WriteLine(oddNumber);
                if (i==n-1)
                {
                    Console.WriteLine($"Sum: {sumOdd}");
                }
            }

        }
    }
}
