using System;
using System.Collections.Generic;
using System.Linq;

namespace p02_Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sqnceSize = int.Parse(Console.ReadLine());
            
            var lsSqnces = new List<int[]>();

            string inputLine = "";

            do
            {
                inputLine = Process(sqnceSize, lsSqnces);
            } while (!"Clone them!".Equals(inputLine));
        }

        public static string Process(int sqnceSize, List<int[]> lsSqnces)
        {
            string inputLine = Console.ReadLine();
            if ("Clone them!".Equals(inputLine))
            {
                WriteOut(lsSqnces);
            }
            else
            {
                LoadList(inputLine, sqnceSize, lsSqnces);
            }
            return inputLine;
        }

        static void LoadList(string inputLine, int sqnceSize, List<int[]> lsSqnces)
        {
            string[] strArr = inputLine.Split(new char[] { '!'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int[] intArr = new int[sqnceSize];
            for (int i = 0; i < sqnceSize; i++)
            {
                intArr[i] = int.Parse(strArr[i]);
            }
            lsSqnces.Add(intArr);
        }

        static void WriteOut(List<int[]> lsSqnces)
        {
            int maxOnesSeqLength = 0;
            
            var listRes = new List<int[]>();
            for (int i = 0; i < lsSqnces.Count; i++)
            {
                maxOnesSeqLength = FillArrSqncs(lsSqnces[i], i,maxOnesSeqLength, listRes);
            }
            var lastArrInserted = listRes[listRes.Count - 1];
            Console.WriteLine($"Best DNA sample {lastArrInserted[3]+1} with sum: {lastArrInserted[2]}.");
            Console.WriteLine(string.Join(" ", lsSqnces[lastArrInserted[3]]));
        }

        static int FillArrSqncs(int[] arrInts, int indxI,int maxOnesSeqLength, List <int[]> listRes)
        {
            int strtIndex = 0;
            int bestLengthOnes = 0;
            int tmpIndx = 0;
            int lngthOnes = 0;
            int sumOnes = 0;
            var arrRes = new int[4];
            for (int i = 0; i < arrInts.Length; i++)
            {
                sumOnes += arrInts[i];
            }

            for (int i = 0; i < arrInts.Length; i++)
            {
                tmpIndx = i;
                lngthOnes = 0;
                if (arrInts[i]==1)
                {
                    lngthOnes = 1;
                    for (int j = 1; j < arrInts.Length; j++)
                    {
                        int k = i + j;
                        if (k>arrInts.Length-1)break;
                        if (arrInts[k]==1)
                        {
                            tmpIndx = k;
                            lngthOnes += 1;
                        }
                        else break;
                    }
                }
                if (lngthOnes>bestLengthOnes)
                {
                    strtIndex = i;
                    bestLengthOnes = lngthOnes;
                }
                i = tmpIndx;
            }
            if (maxOnesSeqLength <= bestLengthOnes)
            {
                int indxLs = Math.Max(-1, (listRes.Count - 1));
                arrRes[0] = bestLengthOnes; arrRes[1] = strtIndex; arrRes[2] = sumOnes; arrRes[3] = indxI;
                if (indxLs==-1)
                {
                    listRes.Add(arrRes);
                    return bestLengthOnes;
                }
                var lastArrInserted = listRes[listRes.Count - 1];
                if (lastArrInserted[1] >= strtIndex)
                {
                    
                    if (lastArrInserted[1] == strtIndex)
                    {
                        if (lastArrInserted[2] < sumOnes)
                        {
                            listRes.Add(arrRes);
                        }
                    }
                    else listRes.Add(arrRes);

                }
                return bestLengthOnes;
            }
            else return maxOnesSeqLength;
            
        }
    }
}
