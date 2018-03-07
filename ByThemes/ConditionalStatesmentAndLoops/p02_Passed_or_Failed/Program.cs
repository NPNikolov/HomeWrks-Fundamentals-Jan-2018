using System;

namespace p02_Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade > 2.99)
            {
                Console.WriteLine("Passed!");
            }
            else Console.WriteLine("Failed!");
        }
    }
}
