using System;
using System.Linq;
using System.Collections.Generic;


namespace p07_Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int arrSize = array.Length;
            int[] arraySecond = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int arrSizeSecond = arraySecond.Length;
            int[] smallerArr, biggerArr;
    
            if (arrSize<arrSizeSecond)
            {
                smallerArr = array;
                biggerArr = arraySecond;
            }
            else
            {
                smallerArr = arraySecond;
                biggerArr = array;
            }
            int biggerSize = biggerArr.Length;
            List <int> listInts = new List<int>();
            for (int i = 0; i < smallerArr.Length; i++)
            {
                listInts.Add(smallerArr[i]);
            }
            while (listInts.Count< biggerSize)
            {
                for (int i = 0; i < smallerArr.Length; i++)
                {
                    listInts.Add(smallerArr[i]);
                }
            }

            int[] newArr = listInts.ToArray();
            for (int i = 0; i < biggerSize; i++)
            {
                biggerArr[i] += newArr[i];
            }
            string biggerStr = string.Join(" ", biggerArr);
            Console.WriteLine(biggerStr);
        }
    }
}
