using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int arrSize = array.Length;
            int theNum = array[0];
            int nmbrOccrncs = 1;
            int cntr = 1;
            for (int i = 0; i < arrSize-1; i++)
            {
                if (array[i]==array[i+1])
                {
                    cntr++;
                }
                if ((array[i] != array[i + 1])||(i==arrSize-2))
                {
                    if (cntr>nmbrOccrncs)
                    {
                        nmbrOccrncs = cntr;
                        theNum = array[i];
                    }
                    cntr = 1;
                }
            }
            for (int i = 0; i < nmbrOccrncs; i++)
            {
                Console.Write(theNum);
                Console.Write(" ");
            }

        }
    }
}
