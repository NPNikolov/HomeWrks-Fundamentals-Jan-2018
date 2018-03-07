using System;
using System.Linq;

namespace p07_Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int arrSize = array.Length;
                int bestStart = 0;
                int bestLength = 1;
                for (int i = 0; i < arrSize; i++)
                {
                    int currTest = 1;
                    for (int j = 1; j < arrSize - i; j++)
                    {
                    
                        if (array[i] < array[i + j])
                        {
                        if (array[i+j]<=array[i+j-1])
                        {
                            break;
                        }
                        currTest++;
                        
                        }
                        else break;
                    }
                    if (currTest > bestLength)
                    {
                        bestLength = currTest;
                        bestStart = i;
                        i += bestLength - 1;
                    }
                }
                for (int i = bestStart; i < bestStart + bestLength; i++)
                {
                    Console.Write(array[i]);
                    Console.Write(" ");
                }

            
        }
    }
}
