using System;

namespace p11_Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSteps = 0;

            while (maxSteps<11)
            {
                maxSteps += 1;
                int oddNumber = int.Parse(Console.ReadLine());
                if (0==oddNumber%2)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    oddNumber = Math.Abs(oddNumber);
                    Console.WriteLine($"The number is: {oddNumber}");
                    break;
                }
            }
        }
    }
}
