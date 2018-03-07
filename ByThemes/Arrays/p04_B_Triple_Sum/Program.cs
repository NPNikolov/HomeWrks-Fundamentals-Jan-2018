using System;
using System.Linq;

namespace p04_B_Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int arrSize = array.Length;

            bool testBool = false;
            for (int i = 0; i < arrSize; i++)
            {
                int a = array[i];
                for (int j = i + 1; j < arrSize; j++)
                {
                    int b = array[j];
                    int testVal = a + b;
                    for (int k = 0; k < arrSize; k++)
                    {
                        if (testVal == array[k])
                        {
                            Console.WriteLine($"{a} + {b} == {testVal}");
                            testBool = true;
                            break;
                        }
                    }
                }
            }
            if (!testBool) Console.WriteLine("No");


        }

    }

}
