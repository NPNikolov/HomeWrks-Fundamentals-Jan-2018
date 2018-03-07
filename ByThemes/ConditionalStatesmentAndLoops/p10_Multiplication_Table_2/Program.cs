using System;

namespace p10_Multiplication_Table_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int multilier = int.Parse(Console.ReadLine());
            if (multilier > 10)
            {
                int product = theInteger * multilier;
                Console.WriteLine("{0} X {1} = {2}", theInteger, multilier, product);
            }
            else
            {
                for (int i = multilier; i <= 10; i++)
                {
                    int product = theInteger * i;
                    Console.WriteLine("{0} X {1} = {2}", theInteger, i, product);
                }
            }
        }
    }
}
