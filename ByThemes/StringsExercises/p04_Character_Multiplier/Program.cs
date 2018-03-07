using System;
using System.Linq;

namespace p04_Character_Multiplier
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] inpStr = Console.ReadLine().Split(' ').ToArray();
            int rslt = CalcMultipliedCharsValue(inpStr[0], inpStr[1]);

            Console.WriteLine(rslt);
        }
        public static int CharCode(char chr)
        {
            return chr;
        }
        public static int CalcMultipliedCharsValue(string strOne, string strTwo)
        {
            string shortString = "";
            string longString = "";
            int rslt = 0;

            if (strOne.Length > strTwo.Length)
            {
                shortString = strTwo;
                longString = strOne;
            }
            else
            {
                shortString = strOne;
                longString = strTwo;
            }
            int smallerLength = shortString.Length;
            for (int i = 0; i < longString.Length; i++)
            {
                int val = CharCode(longString[i]);
                if (i < smallerLength)
                {
                    val *= CharCode(shortString[i]);
                }
                rslt += val;
            }
            return rslt;
        }
    }
}
