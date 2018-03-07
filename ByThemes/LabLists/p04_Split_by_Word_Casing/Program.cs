using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new char[] { ' ',',',';',':','.','!','(',')' ,'"','\'','\\','/','[',']'}, StringSplitOptions.RemoveEmptyEntries);
            int arrSize = array.Length;
            List<string> smallerLs = new List<string>();
            List<string> biggerLs = new List<string>();
            List<string> mixedLs = new List<string>();
            char[] arraySmallers = ReturnCharArray('a', 'z');
            char[] arrayBiggerers = ReturnCharArray('A', 'Z');
            for (int i = 0; i < arrSize; i++)
            {
                if (CheckAllSmaller(arraySmallers,array[i]))
                {
                    smallerLs.Add(array[i]);
                }else if (CheckAllBigger(arrayBiggerers, array[i]))
                {
                    biggerLs.Add(array[i]);
                }else mixedLs.Add(array[i]);
            }
            PrintResult("Lower-case:", smallerLs);
            PrintResult("Mixed-case:", mixedLs);
            PrintResult("Upper-case:", biggerLs);
        }
        static void PrintResult(string hdr, List<string> lst)
        {
            string reslt = "";
            reslt = string.Join(", ", lst);
            Console.WriteLine($"{hdr} {reslt}");
        }
        static bool CheckAllSmaller(char[] smallArr, string testWrd)
        {
            int lngth = testWrd.Length;
            bool allSmaller = true;
            for (int i = 0; i < lngth; i++)
            {
                char testChar = testWrd[i];
                if (! smallArr.Contains(testChar))
                {
                    allSmaller = false;
                    break;
                }
            }
            return allSmaller;
        }
        static bool CheckAllBigger(char[] bigArr, string testWrd)
        {
            int lngth = testWrd.Length;
            bool allBigger = true;
            for (int i = 0; i < lngth; i++)
            {
                char testChar = testWrd[i];
                if (!bigArr.Contains(testChar))
                {
                    allBigger = false;
                    break;
                }
            }
            return allBigger;
        }
        static char[] ReturnCharArray(char first, char last)
        {
            char[] arrayChars = new char[26];
            int indx = 0;
            for (char i = first; i <= last; i++)
            {
                arrayChars[indx] = i;
                indx++;
            }
            return arrayChars;
        }

    }
}
