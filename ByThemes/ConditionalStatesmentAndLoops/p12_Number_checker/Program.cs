using System;

namespace p12_Number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string test_str = Console.ReadLine();
            double test_dbl = 0;
            try
            {
                test_dbl = double.Parse(test_str);
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
            
        }
    }
}
