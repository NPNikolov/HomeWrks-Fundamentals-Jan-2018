using System;

namespace p04_Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number_str = Console.ReadLine();
            number_str = StringReverse(number_str);
            Console.WriteLine(number_str);
        }

        static string StringReverse(string number_str)
        {
            int lngth = number_str.Length;
            string reslt = "";
            for (int i = lngth-1; i >= 0; i--)
            {
                reslt += number_str[i].ToString();
            }
            return reslt;
        }
    }
}
