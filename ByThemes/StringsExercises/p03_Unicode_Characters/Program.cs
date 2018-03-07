using System;

namespace p03_Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpStr = Console.ReadLine();
            char[] chrArr = inpStr.ToCharArray();
            string uniCode = "";
            for (int i = 0; i < chrArr.Length; i++)
            {
                string escape = "\\u" + ((int)chrArr[i]).ToString("X").PadLeft(4, '0');
                uniCode += escape.ToLower();
            }
            
            Console.WriteLine(uniCode);
        }
    }
}
