using System;
using System.Linq;
using System.Numerics;

namespace p04_Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();
            int arrSize = array.Length;
            
            bool testBool = false;
            for (int i = 0; i < arrSize; i++)
            {
                BigInteger a = array[i];
                for (int j = i+1; j < arrSize; j++)
                {
                    BigInteger b = array[j];
                    BigInteger testVal = a + b;
                    for (int k = 0; k < arrSize; k++)
                    {
                        if (testVal ==array[k])
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
