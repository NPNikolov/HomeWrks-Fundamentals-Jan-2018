using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var strArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int sizeArr = strArr.Length;
            Random rnd = new Random();
            for (int i = 0; i < sizeArr; i++)
            {
                string wrd = strArr[i];
                int nmbr = rnd.Next(0, sizeArr - 1);
                strArr[i] = strArr[nmbr];
                strArr[nmbr] = wrd;
            }
            for (int i = 0; i < sizeArr; i++)
            {
                Console.WriteLine(strArr[i]);
            }
        }
    }
}
