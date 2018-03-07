using System;

namespace p09_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            for (int i = 1; i <=10; i++)
            {
                int product = theInteger * i;
                Console.WriteLine("{0} X {1} = {2}", theInteger, i, product);
            }
        }
    }
}
