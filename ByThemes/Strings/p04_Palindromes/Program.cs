using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(new[] { ' ', '!', '.', ',', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var strdMap = new SortedDictionary<string, int>();
            for (int i = 0; i < strArr.Length; i++)
            {
                string wrd = strArr[i];
                int lngth = wrd.Length;
                int mid = lngth / 2 + lngth % 2;
                bool check = true;
                for (int j = 0; j < mid; j++)
                {
                    char chrFromStart = wrd[j];
                    char chrFromEnd = wrd[lngth - 1 - j];
                    if (!(chrFromEnd==chrFromStart))
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    strdMap[wrd] = lngth;
                }
                
            }
            Console.WriteLine(string.Join(", ", strdMap.Keys));
        }
    }
}
