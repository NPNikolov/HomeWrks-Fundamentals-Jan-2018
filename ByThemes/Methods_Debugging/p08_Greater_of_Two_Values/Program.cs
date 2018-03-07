using System;

namespace p08_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            
            if (type.Equals("int"))
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int result = GetMax(num1, num2);
                Console.WriteLine(result);
            }
            else if (type.Equals("char"))
            {
                char chr1 = char.Parse(Console.ReadLine());
                char chr2 = char.Parse(Console.ReadLine());
                char result = GetMax(chr1, chr2);
                Console.WriteLine(result);
            }
            else
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                string result = GetMax(str1, str2);
                Console.WriteLine(result);
            }
            
        }

        static string GetMax(string str1, string str2)
        {
            int res = str1.CompareTo(str2);
            if (res > 0)
            {
                return str1;
            }
            else return str2;
        }
        static char GetMax(char chr1, char chr2)
        {
            if (chr2 > chr1)
            {
                return chr2;
            }
            else return chr1;
        }

        static int GetMax(int num1, int num2)
        {
            if (num2 > num1)
            {
                return num2;
            }
            else return num1;
        }
    }
}
