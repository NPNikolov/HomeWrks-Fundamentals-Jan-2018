using System;
using System.Linq;

namespace p05_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char[] str1Arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            char[] str2Arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            int str1Size = str1Arr.Length;
            int str2Size = str2Arr.Length;
            
            int minSize = Math.Min(str1Size, str2Size);
            byte smaller = 0;
            for (int i = 0; i < minSize; i++)
            {         
                if (str2Arr[i] < str1Arr[i])
                {
                    smaller = 2;
                    break;
                }
                if (str2Arr[i] > str1Arr[i])
                {
                    smaller = 1;
                }
            }
            if (smaller==0)
            {
                if (str2Size >= str1Size)
                {
                    PrintArrays(str1Arr, str2Arr);
                }
                else
                {
                    PrintArrays(str2Arr, str1Arr);
                }
            }else if(smaller==2)
            {
                PrintArrays(str2Arr, str1Arr);
            }
            else
            {
                PrintArrays(str1Arr, str2Arr);
            }

        }
        static void PrintArrays(char[] arr1, char[] arr2)
        {
            PrintArr(arr1);
            PrintArr(arr2);
        }
        static void PrintArr(char[] arr)
        {
            string tmp = "";
            for (int i = 0; i < arr.Length; i++)
            {
                tmp += arr[i];
            }
            Console.WriteLine(tmp);
        }
    }
}
