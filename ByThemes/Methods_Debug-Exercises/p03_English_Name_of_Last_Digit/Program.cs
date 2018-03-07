using System;

namespace p03_English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number_str = Console.ReadLine();
            int lastNumber = GetLastDigit(number_str);
            number_str = GetEnglishName(lastNumber);
            Console.WriteLine(number_str);
        }

        static string GetEnglishName(int lastNumber)
        {
            string resltName = "";
            switch (lastNumber)
            {
                case 1:resltName = "one";
                    break;
                case 2:
                    resltName = "two";
                    break;
                case 3:
                    resltName = "three";
                    break;
                case 4:
                    resltName = "four";
                    break;
                case 5:
                    resltName = "five";
                    break;
                case 6:
                    resltName = "six";
                    break;
                case 7:
                    resltName = "seven";
                    break;
                case 8:
                    resltName = "eight";
                    break;
                case 9:
                    resltName = "nine";
                    break;
                case 0:
                    resltName = "zero";
                    break;
            }
            return resltName;
        }

        static int GetLastDigit(string number_str)
        {
            int length = number_str.Length;
            number_str = number_str[length - 1].ToString();
            int reslt = int.Parse(number_str);
            return reslt;
        }
    }
}
