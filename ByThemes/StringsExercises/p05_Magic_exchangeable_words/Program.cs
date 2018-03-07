using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inpStr = Console.ReadLine().Split(' ').ToArray();
            string result = CheckExchabgeableWords(inpStr[0],inpStr[1]).ToString();
            Console.WriteLine(result.ToLower());
        }
        public static bool CheckExchabgeableWords(string strOne, string strTwo)
        {
            var listOne = ListDffrntChars(strOne);
            var listTwo = ListDffrntChars(strTwo);
            if (listOne.Count == listTwo.Count)
            {
                return true;
            }
            else return false;
        }
        public static List<char> ListDffrntChars(string strTest)
        {
            var charsList = new List<char>(strTest.Length);
            for (int i = 0; i < strTest.Length; i++)
            {
                if (! charsList.Contains(strTest[i]))
                {
                    charsList.Add(strTest[i]);
                }
            }
            return charsList;
        }

    }
}
