using System;

namespace p09_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int sum = SumEven(number)*SumOdd(number);
            Console.WriteLine(sum);
        }

        static int SumEven(int number)
        {
            string tmp = "" + number;
            string tmp2 = "";
            int lengthNmbr = tmp.Length;
            int reslt = 0;
            for (int i = 0; i < lengthNmbr; i++)
            {
                
                tmp2 = tmp[i].ToString();
                int digit = int.Parse(tmp2);
                if (digit%2 == 1)
                {
                    reslt += digit;
                }     
            }
            return reslt;
        }
        static int SumOdd(int number)
        {
            string tmp = "" + number;
            string tmp2 = "";
            int lengthNmbr = tmp.Length;
            int reslt = 0;
            for (int i = 0; i < lengthNmbr; i++)
            {
                tmp2 = tmp[i].ToString();
                int digit = int.Parse(tmp2);
                if (digit % 2 == 0)
                {
                    reslt += digit;
                }
            }
            return reslt;
        }
    }
}
