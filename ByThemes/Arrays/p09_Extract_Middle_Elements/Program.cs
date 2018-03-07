using System;
using System.Linq;

namespace p09_Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            int arrSize = array.Length;
            string middleElmnts = GetMiddleElms(arrSize, array);
            middleElmnts = "{ " + middleElmnts + " }";
            Console.WriteLine(middleElmnts);
        }

        static string GetMiddleElms(int arrSize, long[] array)
        {
            if (arrSize==1)
            {
                return array[0].ToString();
            }
            else if (arrSize%2==0)
            {
                int middleNmbr = arrSize / 2;
                return "" + array[middleNmbr - 1] + ", " + array[middleNmbr];
            }
            else
            {
                int middleNmbr = arrSize / 2;
                return "" + array[middleNmbr - 1] + ", " + array[middleNmbr] + ", " + array[middleNmbr + 1];
            }
        }
    }
}
