using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int arrSize = array.Length;
            int[] arrayBmbNmbr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var listNmbrs = new List<int>(arrSize);
            listNmbrs = array.ToList();
            for (int i = 0; i < listNmbrs.Count; i++)
            {
                i = BlowNumber(listNmbrs, i, arrayBmbNmbr[0], arrayBmbNmbr[1]);
            }
            int sum = 0;
            for (int i = 0; i < listNmbrs.Count; i++)
            {
                sum += listNmbrs[i];
            }
            Console.WriteLine(sum);
        }

        static int BlowNumber(List<int> listNmbrs, int pstn, int bomb, int nmbrDmg)
        {
            int fromPstn = pstn;
            if (listNmbrs[pstn] == bomb)
            {
                for (int i = 1; i <=nmbrDmg ; i++)
                {
                    if ((pstn+1)<listNmbrs.Count)
                    {
                        listNmbrs.RemoveAt(pstn + 1);
                    }
                }
                listNmbrs.RemoveAt(pstn);
                fromPstn = pstn - 1;
                for (int i = 1; i <= nmbrDmg; i++)
                {
                    if ((pstn - i) >= 0)
                    {
                        listNmbrs.RemoveAt(pstn -i);
                        fromPstn--;
                    }
                }

            }
            return fromPstn;
        }
    }
}
