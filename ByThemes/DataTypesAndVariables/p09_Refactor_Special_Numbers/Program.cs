using System;

namespace p09_Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= maxNumber; i++)
            {
                int testedNumber = i;
                int testDigit = 0;
               
                while (testedNumber > 0)
                {
                    testDigit += testedNumber % 10;
                    testedNumber = testedNumber / 10;
                }
                bool isSpecialNumber = (testDigit == 5) || (testDigit == 7) || (testDigit == 11);

                Console.WriteLine($"{i} -> {isSpecialNumber}");
                
            }
        }
    }
}
