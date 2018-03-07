using System;

namespace p09_Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string strng = "";
            for (int i = 0; i < 3; i++)
            {
                strng += Console.ReadLine();
            }
            for (int i = 2; i >= 0; i--)
            {
                Console.Write(strng[i]);
            }
        }
    }
}
