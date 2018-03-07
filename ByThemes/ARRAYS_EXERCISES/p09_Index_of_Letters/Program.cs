using System;

namespace p09_Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arrChars = new int[256];
            int indx = 0;
            for (int i = 'a'; i <='z'; i++)
            {
                arrChars[i] = indx;
                indx++;
            }
            string toPrcs = Console.ReadLine();
            int strSize = toPrcs.Length;
            for (int i = 0; i < strSize; i++)
            {
                char crrntChar = toPrcs[i];
                Console.WriteLine("{0} -> {1}",toPrcs[i],arrChars[crrntChar]);
            }

            
        }
    }
}
