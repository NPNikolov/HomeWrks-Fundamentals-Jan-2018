using System;

namespace p15_Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperBound = int.Parse(Console.ReadLine());
            
            for (int testNumber = 2; testNumber <= upperBound; testNumber++)
            {
                bool isPrime = true;
                for (int devider = 2; devider <= Math.Sqrt(testNumber); devider++)
                {
                    if (testNumber % devider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{testNumber} -> {isPrime}");
            }
        }
    }
}
