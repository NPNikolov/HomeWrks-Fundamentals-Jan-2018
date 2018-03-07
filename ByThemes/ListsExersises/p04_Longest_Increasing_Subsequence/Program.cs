using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int arrSize = array.Length;

            int maxLngth = 0;
            string maxResult = "";
            
            for (int i = 0; i < arrSize; i++)
            {
                List<int> intsList = FinfSqnc(array, arrSize, i);
                if (maxLngth < intsList.Count)
                {
                    maxLngth = intsList.Count;
                    maxResult = string.Join(" ", intsList);
                }
            }

            Console.WriteLine(maxResult);

        }

        static List<int> FinfSqnc(int[] array, int arrSize, int crrntPstn)
        {
            List<int> arrLs = new List<int>();
            int crrntInt = array[crrntPstn];
            arrLs.Add(crrntInt);
            for (int i = crrntPstn+1; i < arrSize; i++)
            {
                if (crrntInt<array[i])
                {
                    arrLs.Add(array[i]);
                }    
            }
            if (arrLs.Count > 1)
            {
                List<int>[] arrListsArray = new List<int>[arrLs.Count];
                for (int j = arrLs.Count - 1; j >=0 ; j--)
                {
                    List<int> tmpLs = new List<int>();
                    for (int k = j; k >= 0; k--)
                    {
                        int tmpIndx = tmpLs.Count - 1;
                        if (tmpIndx == -1) {
                            //tmpLs.Add(arrLs[k]);
                            if (-1 == FindMatched(arrLs, k, arrLs[k]))
                            {
                                tmpLs.Add(arrLs[k]);
                            }
                        }
                        else
                        {

                            if (tmpLs[tmpIndx] > arrLs[k])
                            {
                                if (-1 == FindMatched(arrLs, k, arrLs[k]))
                                {
                                    tmpLs.Add(arrLs[k]);
                                }

                            }
                        }
                    }
                    arrListsArray[j] = tmpLs;

                }
                int maxIndx = 0;
                int maxLngth = 0;
                Array.Reverse(arrListsArray);
                for (int i = 0; i < arrListsArray.Length; i++)
                {

                    if (arrListsArray[i].Count>=maxLngth)
                    {
                        maxLngth = arrListsArray[i].Count;
                        maxIndx = i;
                    }
                }
                List<int> resLs = new List<int>();
                for (int i = arrListsArray[maxIndx].Count-1;i>=0 ; i--)
                {
                    resLs.Add(arrListsArray[maxIndx][i]);
                }
                return resLs;
            }
            else return arrLs;

        }
        static int FindMatched(List<int> lstArr, int pstn, int elmnt)
        {
            for (int i = pstn - 1; i >= 0; i--)
            {
                if (lstArr[i]>elmnt)
                {
                    for (int j = i-1; j >= 0; j--)
                    {
                        if (lstArr[j]==elmnt)
                        {
                            return j;
                        }
                    }
                }
            }
            return -1;
        }
        
    }
}
