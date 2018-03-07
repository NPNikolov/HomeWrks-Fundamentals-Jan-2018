using System;
using System.Collections.Generic;
using System.Linq;

namespace p03_Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intsList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //int limit = array[0] - array[1];
            string found = "NO!";
            for (int i = array[1]; i < array[0]; i++)
            {
                if (intsList[i]==array[2])
                {
                    found = "YES!";
                }
            }
            Console.WriteLine(found);
        }
    }
}
