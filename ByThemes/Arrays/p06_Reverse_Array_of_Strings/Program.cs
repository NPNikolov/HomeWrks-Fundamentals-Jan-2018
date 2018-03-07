using System;

namespace p06_Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            
            Array.Reverse(array);
            string strng = string.Join(" ", array);
            Console.WriteLine(strng);
        }
    }
}
